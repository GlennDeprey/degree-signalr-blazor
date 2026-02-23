using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Data;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Models.ResultModels;
using Pin.LiveSports.Core.Services.Interfaces;

namespace Pin.LiveSports.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly ApplicationDbContext _context;
        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ResultModel<IEnumerable<Team>>> GetTeamsAsync()
        {
            var teams = await _context.Teams.ToListAsync();
            var result = new ResultModel<IEnumerable<Team>>();

            if (!teams.Any())
            {
                result.ErrorMessage = "No teams found.";
                return result;
            }

            result.Data = teams;
            return result;
        }
        public async Task<ResultModel<Team>> GetTeamByIdAsync(Guid id)
        {
            var team = await _context.Teams
                .Include(t => t.Players)
                .ThenInclude(p => p.Role)
                .FirstOrDefaultAsync(t => t.Id == id);
            var result = new ResultModel<Team>();
            if (team == null)
            {
                result.ErrorMessage = "Team not found.";
                return result;
            }

            result.Data = team;
            return result;
        }
        public async Task<BaseResultModel> UpdateTeamScoreAsync(Guid id, bool hasWon = false)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(t => t.Id == id);
            var result = new BaseResultModel();
            if (team == null)
            {
                result.ErrorMessage = "Team not found.";
                return result;
            }

            if (hasWon)
            {
                team.Wins++;
            }
            else
            {
                team.Losses++;
            }

            _context.Teams.Update(team);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                result.ErrorMessage = "Failed to update team score.";
            }
            catch (DbUpdateException)
            {
                result.ErrorMessage = "Failed to update team score.";
            }

            return result;
        }
    }
}
