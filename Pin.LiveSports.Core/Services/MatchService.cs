using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Data;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Models.RequestModel;
using Pin.LiveSports.Core.Models.ResultModels;
using Pin.LiveSports.Core.Services.Interfaces;
using MatchType = Pin.LiveSports.Core.Models.MatchType;

namespace Pin.LiveSports.Core.Services
{
    public class MatchService : IMatchService
    {
        private readonly ApplicationDbContext _context;
        public MatchService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResultModel<IEnumerable<Champion>>> GetChampionsAsync()
        {
            var champions = await _context.Champions.ToListAsync();
            var result = new ResultModel<IEnumerable<Champion>>();

            if (!champions.Any())
            {
                result.ErrorMessage = "No champions found.";
                return result;
            }

            result.Data = champions;
            return result;
        }

        public async Task<ResultModel<IEnumerable<MatchType>>> GetMatchTypesAsync()
        {
            var matchTypes = await _context.MatchTypes.ToListAsync();
            var result = new ResultModel<IEnumerable<MatchType>>();
            if (!matchTypes.Any())
            {
                result.ErrorMessage = "No match types found.";
                return result;
            }
            result.Data = matchTypes;
            return result;
        }

        public async Task<ResultModel<IEnumerable<Match>>> GetMatchesAsync()
        {
            var matches = await _context.Matches
                .Include(m => m.RedTeam)
                .Include(m => m.BlueTeam)
                .Include(m => m.MatchType)
                .ToListAsync();
            var result = new ResultModel<IEnumerable<Match>>();
            if (!matches.Any())
            {
                result.ErrorMessage = "No matches found.";
                return result;
            }
            result.Data = matches.OrderBy(m => m.Created);
            return result;
        }

        public async Task<BaseResultModel> CreateMatchResultAsync(CreateMatchRequestModel matchResult)
        {
            var result = new BaseResultModel();
            var match = new Match
            {
                MatchTypeId = matchResult.MatchTypeId,
                BlueTeamId = matchResult.BlueTeamId,
                RedTeamId = matchResult.RedTeamId,
                BlueTeamWins = matchResult.BlueTeamWins,
                RedTeamWins = matchResult.RedTeamWins,
                Created = DateTime.UtcNow
            };

            await _context.Matches.AddAsync(match);
            var saveResult = await _context.SaveChangesAsync();
            if (saveResult == 0)
            {
                result.ErrorMessage = "Failed to create match result.";
            }

            return result;
        }
    }
}
