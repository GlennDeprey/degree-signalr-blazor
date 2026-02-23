using Pin.LiveSports.Core.Models.ResultModels;
using Pin.LiveSports.Core.Models;
using MatchType = Pin.LiveSports.Core.Models.MatchType;
using Pin.LiveSports.Core.Models.RequestModel;

namespace Pin.LiveSports.Core.Services.Interfaces
{
    public interface IMatchService
    {
        Task<ResultModel<IEnumerable<Champion>>> GetChampionsAsync();
        Task<ResultModel<IEnumerable<MatchType>>> GetMatchTypesAsync();
        Task<ResultModel<IEnumerable<Match>>> GetMatchesAsync();
        Task<BaseResultModel> CreateMatchResultAsync(CreateMatchRequestModel matchResult);
    }
}
