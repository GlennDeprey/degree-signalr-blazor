using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using Pin.LiveSports.Blazor.Hubs.Messages;
using Pin.LiveSports.Core.Types;
using Pin.LiveSports.Blazor.ViewModels.Champions;
using Pin.LiveSports.Blazor.ViewModels.Matches;
using Pin.LiveSports.Blazor.ViewModels.Teams;
using Pin.LiveSports.Blazor.ViewModels.Towers;
using System.Net.WebSockets;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Blazor.ViewModels.Anouncements;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class MatchHub : Hub
    {

        private readonly IMemoryCache _cache;
        private readonly string _cacheKey = "MatchState";
        public MatchHub(IMemoryCache cache)
        {
            _cache = cache;
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                return;
            }

            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromHours(2));

            var matchViewModel = new MatchViewModel();
            _cache.Set(_cacheKey, matchViewModel, cacheEntryOptions);
        }

        override public async Task OnConnectedAsync()
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                await Clients.Caller.SendAsync(HubContants.ReceiveMatchInfo, match);
            }
        }

        public async Task SendCancelMatch()
        {
            var match = new MatchViewModel();
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel cachedMatch))
            {
                cachedMatch = match;
                _cache.Set(_cacheKey, cachedMatch);
            }
            await Clients.All.SendAsync(HubContants.ReceiveCancelMatch, match);
        }

        public async Task SendMatchState(MatchState state)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                match.State = state;
                _cache.Set(_cacheKey, match);
            }

            await Clients.All.SendAsync(HubContants.ReceiveMatchStateUpdate, state);
        }

        public async Task SendMatchTypeUpdate(MatchTypeViewModel matchType)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                match.MatchType = matchType;
                _cache.Set(_cacheKey, match);
            }
            await Clients.All.SendAsync(HubContants.ReceiveMatchTypeUpdate, matchType);
        }

        public async Task SendNextMatchUpdate(MatchViewModel newMatch)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                match = newMatch;
                _cache.Set(_cacheKey, match);
            }
            await Clients.All.SendAsync(HubContants.ReceiveNextMatchUpdate, newMatch);
        }

        public async Task SendTeamUpdate(TeamMatchViewModel team, TeamType teamType)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                if (teamType == TeamType.Blue)
                {
                    match.BlueTeam = team;
                }
                else if (teamType == TeamType.Red)
                {
                    match.RedTeam = team;
                }
                _cache.Set(_cacheKey, match);
            }

            await Clients.All.SendAsync(HubContants.ReceiveTeamUpdate, team, teamType);
        }

        public async Task SendBanUpdate(SendChampion champion, int index, TeamType team)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                if (team == TeamType.Blue)
                {
                    match.BlueTeam.Bans[index] = new ChampionViewModel { Id = champion.Id, Name = champion.Name };
                }
                else if (team == TeamType.Red)
                {
                    match.RedTeam.Bans[index] = new ChampionViewModel { Id = champion.Id, Name = champion.Name };
                }

                _cache.Set(_cacheKey, match);
            }

            await Clients.All.SendAsync(HubContants.ReceiveBanUpdate, champion, index, team);
        }
        public async Task SendPickUpdate(SendChampion champion, int index, TeamType team)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                if (team == TeamType.Blue)
                {
                    match.BlueTeam.Champions[index] = new ChampionViewModel { Id = champion.Id, Name = champion.Name };
                }
                else if (team == TeamType.Red)
                {
                    match.RedTeam.Champions[index] = new ChampionViewModel { Id = champion.Id, Name = champion.Name };
                }

                _cache.Set(_cacheKey, match);
            }

            await Clients.All.SendAsync(HubContants.ReceivePickUpdate, champion, index, team);
        }

        public async Task SendTowerDestroyed(double x, double y)
        {
            var cross = new CrossViewModel { X = x, Y = y };
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                match.TowersDestroyed.Add(cross);
            }
            await Clients.All.SendAsync(HubContants.ReceiveTowerDestroyed, cross);
        }

        public async Task SendPlayerScoreUpdate(int index, TeamType team, ScoreType type)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                if (team == TeamType.Blue)
                {
                    switch (type)
                    {
                        case ScoreType.Kill:
                            match.BlueTeam.PlayerScores[index].Kills++;
                            break;
                        case ScoreType.Death:
                            match.BlueTeam.PlayerScores[index].Deaths++;
                            break;
                        case ScoreType.Assist:
                            match.BlueTeam.PlayerScores[index].Assists++;
                            break;
                    }
                }
                else if (team == TeamType.Red)
                {
                    switch (type)
                    {
                        case ScoreType.Kill:
                            match.RedTeam.PlayerScores[index].Kills++;
                            break;
                        case ScoreType.Death:
                            match.RedTeam.PlayerScores[index].Deaths++;
                            break;
                        case ScoreType.Assist:
                            match.RedTeam.PlayerScores[index].Assists++;
                            break;
                    }
                }
                _cache.Set(_cacheKey, match);
            }

            await Clients.All.SendAsync(HubContants.ReceivePlayerScoreUpdate, index, team, type);
        }

        public async Task SendLogbookMessage(string message)
        {
            await Clients.All.SendAsync(HubContants.ReceiveLogbookMessage, message);
        }

        public async Task SendGameResult(MatchViewModel gameMatch)
        {
            if (_cache.TryGetValue(_cacheKey, out MatchViewModel match))
            {
                match = gameMatch;
                _cache.Set(_cacheKey, match);
            }
            await Clients.All.SendAsync(HubContants.ReceiveGameResult, gameMatch);
        }
        public async Task SendRefreshPlayedMatches()
        {
            await Clients.All.SendAsync(HubContants.ReceiveRefreshPlayedMatches);
        }
        public async Task SendRefreshScoreboard()
        {
            await Clients.All.SendAsync(HubContants.ReceivedRefreshScoreboard);
        }

        public async Task SendAnnouncement(AnnouncementViewModel announcement)
        {
            await Clients.All.SendAsync(HubContants.ReceiveAnnouncement, announcement);
        }
    }
}
