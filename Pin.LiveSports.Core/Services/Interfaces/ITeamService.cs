using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Models.ResultModels;

namespace Pin.LiveSports.Core.Services.Interfaces
{
    public interface ITeamService
    {
        Task<ResultModel<IEnumerable<Team>>> GetTeamsAsync();
        Task<ResultModel<Team>> GetTeamByIdAsync(Guid id);
        Task<BaseResultModel> UpdateTeamScoreAsync(Guid id, bool hasWon = false);
    }
}
