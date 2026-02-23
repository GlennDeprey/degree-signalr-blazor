namespace Pin.LiveSports.Core.Models.ResultModels
{
    public class BaseResultModel
    {
        public bool IsSuccess => string.IsNullOrWhiteSpace(ErrorMessage);
        public string ErrorMessage { get; set; }
    }
}
