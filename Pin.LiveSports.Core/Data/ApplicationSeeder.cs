using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Core.Models;
using MatchType = Pin.LiveSports.Core.Models.MatchType;

namespace Pin.LiveSports.Core.Data
{
    public class ApplicationSeeder
    {
        public void SeedData(ModelBuilder modelBuilder)
        {
            #region Champions

            var champions = new List<Champion>
            {
                new Champion { Id = Guid.NewGuid(), Name = "Aatrox" },
                new Champion { Id = Guid.NewGuid(), Name = "Ahri" },
                new Champion { Id = Guid.NewGuid(), Name = "Akali" },
                new Champion { Id = Guid.NewGuid(), Name = "Alistar" },
                new Champion { Id = Guid.NewGuid(), Name = "Amumu" },
                new Champion { Id = Guid.NewGuid(), Name = "Anivia" },
                new Champion { Id = Guid.NewGuid(), Name = "Annie" },
                new Champion { Id = Guid.NewGuid(), Name = "Aphelios" },
                new Champion { Id = Guid.NewGuid(), Name = "Ashe" },
                new Champion { Id = Guid.NewGuid(), Name = "Aurelion Sol" },
                new Champion { Id = Guid.NewGuid(), Name = "Azir" },
                new Champion { Id = Guid.NewGuid(), Name = "Bard" },
                new Champion { Id = Guid.NewGuid(), Name = "Blitzcrank" },
                new Champion { Id = Guid.NewGuid(), Name = "Brand" },
                new Champion { Id = Guid.NewGuid(), Name = "Braum" },
                new Champion { Id = Guid.NewGuid(), Name = "Caitlyn" },
                new Champion { Id = Guid.NewGuid(), Name = "Camille" },
                new Champion { Id = Guid.NewGuid(), Name = "Cassiopeia" },
                new Champion { Id = Guid.NewGuid(), Name = "Cho gath" },
                new Champion { Id = Guid.NewGuid(), Name = "Corki" },
                new Champion { Id = Guid.NewGuid(), Name = "Darius" },
                new Champion { Id = Guid.NewGuid(), Name = "Diana" },
                new Champion { Id = Guid.NewGuid(), Name = "Draven" },
                new Champion { Id = Guid.NewGuid(), Name = "Dr Mundo" },
                new Champion { Id = Guid.NewGuid(), Name = "Ekko" },
                new Champion { Id = Guid.NewGuid(), Name = "Elise" },
                new Champion { Id = Guid.NewGuid(), Name = "Evelynn" },
                new Champion { Id = Guid.NewGuid(), Name = "Ezreal" },
                new Champion { Id = Guid.NewGuid(), Name = "Fiddlesticks" },
                new Champion { Id = Guid.NewGuid(), Name = "Fiora" },
                new Champion { Id = Guid.NewGuid(), Name = "Fizz" },
                new Champion { Id = Guid.NewGuid(), Name = "Galio" },
                new Champion { Id = Guid.NewGuid(), Name = "Gangplank" },
                new Champion { Id = Guid.NewGuid(), Name = "Garen" },
                new Champion { Id = Guid.NewGuid(), Name = "Gnar" },
                new Champion { Id = Guid.NewGuid(), Name = "Gragas" },
                new Champion { Id = Guid.NewGuid(), Name = "Graves" },
                new Champion { Id = Guid.NewGuid(), Name = "Hecarim" },
                new Champion { Id = Guid.NewGuid(), Name = "Heimerdinger" },
                new Champion { Id = Guid.NewGuid(), Name = "Illaoi" },
                new Champion { Id = Guid.NewGuid(), Name = "Irelia" },
                new Champion { Id = Guid.NewGuid(), Name = "Ivern" },
                new Champion { Id = Guid.NewGuid(), Name = "Janna" },
                new Champion { Id = Guid.NewGuid(), Name = "Jarvan IV" },
                new Champion { Id = Guid.NewGuid(), Name = "Jax" },
                new Champion { Id = Guid.NewGuid(), Name = "Jayce" },
                new Champion { Id = Guid.NewGuid(), Name = "Jhin" },
                new Champion { Id = Guid.NewGuid(), Name = "Jinx" },
                new Champion { Id = Guid.NewGuid(), Name = "Kaisa" },
                new Champion { Id = Guid.NewGuid(), Name = "Kalista" },
                new Champion { Id = Guid.NewGuid(), Name = "Karma" },
                new Champion { Id = Guid.NewGuid(), Name = "Karthus" },
                new Champion { Id = Guid.NewGuid(), Name = "Kassadin" },
                new Champion { Id = Guid.NewGuid(), Name = "Katarina" },
                new Champion { Id = Guid.NewGuid(), Name = "Kayle" },
                new Champion { Id = Guid.NewGuid(), Name = "Kayn" },
                new Champion { Id = Guid.NewGuid(), Name = "Kennen" },
                new Champion { Id = Guid.NewGuid(), Name = "Khazix" },
                new Champion { Id = Guid.NewGuid(), Name = "Kindred" },
                new Champion { Id = Guid.NewGuid(), Name = "Kled" },
                new Champion { Id = Guid.NewGuid(), Name = "Kog Maw" },
                new Champion { Id = Guid.NewGuid(), Name = "Leblanc" },
                new Champion { Id = Guid.NewGuid(), Name = "Lee Sin" },
                new Champion { Id = Guid.NewGuid(), Name = "Leona" },
                new Champion { Id = Guid.NewGuid(), Name = "Lillia" },
                new Champion { Id = Guid.NewGuid(), Name = "Lissandra" },
                new Champion { Id = Guid.NewGuid(), Name = "Lucian" },
                new Champion { Id = Guid.NewGuid(), Name = "Lulu" },
                new Champion { Id = Guid.NewGuid(), Name = "Lux" },
                new Champion { Id = Guid.NewGuid(), Name = "Malphite" },
                new Champion { Id = Guid.NewGuid(), Name = "Malzahar" },
                new Champion { Id = Guid.NewGuid(), Name = "Maokai" },
                new Champion { Id = Guid.NewGuid(), Name = "Master Yi" },
                new Champion { Id = Guid.NewGuid(), Name = "Miss Fortune" },
                new Champion { Id = Guid.NewGuid(), Name = "Monkey King" },
                new Champion { Id = Guid.NewGuid(), Name = "Mordekaiser" },
                new Champion { Id = Guid.NewGuid(), Name = "Morgana" },
                new Champion { Id = Guid.NewGuid(), Name = "Nami" },
                new Champion { Id = Guid.NewGuid(), Name = "Nasus" },
                new Champion { Id = Guid.NewGuid(), Name = "Nautilus" },
                new Champion { Id = Guid.NewGuid(), Name = "Neeko" },
                new Champion { Id = Guid.NewGuid(), Name = "Nidalee" },
                new Champion { Id = Guid.NewGuid(), Name = "Nocturne" },
                new Champion { Id = Guid.NewGuid(), Name = "Nunu" },
                new Champion { Id = Guid.NewGuid(), Name = "Olaf" },
                new Champion { Id = Guid.NewGuid(), Name = "Orianna" },
                new Champion { Id = Guid.NewGuid(), Name = "Ornn" },
                new Champion { Id = Guid.NewGuid(), Name = "Pantheon" },
                new Champion { Id = Guid.NewGuid(), Name = "Poppy" },
                new Champion { Id = Guid.NewGuid(), Name = "Pyke" },
                new Champion { Id = Guid.NewGuid(), Name = "Qiyana" },
                new Champion { Id = Guid.NewGuid(), Name = "Quinn" },
                new Champion { Id = Guid.NewGuid(), Name = "Rakan" },
                new Champion { Id = Guid.NewGuid(), Name = "Rammus" },
                new Champion { Id = Guid.NewGuid(), Name = "RekSai" },
                new Champion { Id = Guid.NewGuid(), Name = "Renekton" },
                new Champion { Id = Guid.NewGuid(), Name = "Rengar" },
                new Champion { Id = Guid.NewGuid(), Name = "Riven" },
                new Champion { Id = Guid.NewGuid(), Name = "Rumble" },
                new Champion { Id = Guid.NewGuid(), Name = "Ryze" },
                new Champion { Id = Guid.NewGuid(), Name = "Samira" },
                new Champion { Id = Guid.NewGuid(), Name = "Sejuani" },
                new Champion { Id = Guid.NewGuid(), Name = "Senna" },
                new Champion { Id = Guid.NewGuid(), Name = "Seraphine" },
                new Champion { Id = Guid.NewGuid(), Name = "Sett" },
                new Champion { Id = Guid.NewGuid(), Name = "Shaco" },
                new Champion { Id = Guid.NewGuid(), Name = "Shen" },
                new Champion { Id = Guid.NewGuid(), Name = "Shyvana" },
                new Champion { Id = Guid.NewGuid(), Name = "Singed" },
                new Champion { Id = Guid.NewGuid(), Name = "Sion" },
                new Champion { Id = Guid.NewGuid(), Name = "Sivir" },
                new Champion { Id = Guid.NewGuid(), Name = "Skarner" },
                new Champion { Id = Guid.NewGuid(), Name = "Sona" },
                new Champion { Id = Guid.NewGuid(), Name = "Soraka" },
                new Champion { Id = Guid.NewGuid(), Name = "Swain" },
                new Champion { Id = Guid.NewGuid(), Name = "Sylas" },
                new Champion { Id = Guid.NewGuid(), Name = "Syndra" },
                new Champion { Id = Guid.NewGuid(), Name = "Tahm Kench" },
                new Champion { Id = Guid.NewGuid(), Name = "Taliyah" },
                new Champion { Id = Guid.NewGuid(),  Name = "Talon" },
                new Champion { Id = Guid.NewGuid(), Name = "Taric" },
                new Champion { Id = Guid.NewGuid(), Name = "Teemo" },
                new Champion { Id = Guid.NewGuid(), Name = "Thresh" },
                new Champion { Id = Guid.NewGuid(), Name = "Tristana" },
                new Champion { Id = Guid.NewGuid(), Name = "Trundle" },
                new Champion { Id = Guid.NewGuid(), Name = "Tryndamere" },
                new Champion { Id = Guid.NewGuid(), Name = "Twisted Fate" },
                new Champion { Id = Guid.NewGuid(), Name = "Twitch" },
                new Champion { Id = Guid.NewGuid(),  Name = "Udyr" },
                new Champion { Id = Guid.NewGuid(), Name = "Urgot" },
                new Champion { Id = Guid.NewGuid(), Name = "Varus" },
                new Champion { Id = Guid.NewGuid(), Name = "Vayne" },
                new Champion { Id = Guid.NewGuid(), Name = "Veigar" },
                new Champion { Id = Guid.NewGuid(), Name = "Velkoz" },
                new Champion { Id = Guid.NewGuid(), Name = "Vi" },
                new Champion { Id = Guid.NewGuid(), Name = "Viktor" },
                new Champion { Id = Guid.NewGuid(), Name = "Vladimir" },
                new Champion { Id = Guid.NewGuid(), Name = "Volibear" },
                new Champion { Id = Guid.NewGuid(), Name = "Warwick" },
                new Champion { Id = Guid.NewGuid(), Name = "Xayah" },
                new Champion { Id = Guid.NewGuid(), Name = "Xerath" },
                new Champion { Id = Guid.NewGuid(), Name = "Xin Zhao" },
                new Champion { Id = Guid.NewGuid(), Name = "Yasuo" },
                new Champion { Id = Guid.NewGuid(), Name = "Yone" },
                new Champion { Id = Guid.NewGuid(), Name = "Yorick" },
                new Champion { Id = Guid.NewGuid(), Name = "Yuumi" },
                new Champion { Id = Guid.NewGuid(), Name = "Zac" },
                new Champion { Id = Guid.NewGuid(), Name = "Zed" },
                new Champion { Id = Guid.NewGuid(), Name = "Ziggs" },
                new Champion { Id = Guid.NewGuid(), Name = "Zilean" },
                new Champion { Id = Guid.NewGuid(), Name = "Zoe" },
                new Champion { Id = Guid.NewGuid(), Name = "Zyra" }
            };
            #endregion
            #region Roles
            var roles = new List<Role>
            {
                new Role{Id = Guid.NewGuid(), Name = "Jungle", ImageUrl = "jungle.svg", Order = 2},
                new Role{Id = Guid.NewGuid(), Name = "Top", ImageUrl = "top.svg", Order = 1},
                new Role{Id = Guid.NewGuid(), Name = "Mid", ImageUrl = "mid.svg", Order = 3},
                new Role{Id = Guid.NewGuid(), Name = "AD Carry", ImageUrl = "carry.svg", Order = 4},
                new Role{Id = Guid.NewGuid(), Name = "Support", ImageUrl = "support.svg", Order = 5}
            };
            #endregion
            #region Teams

            var teams = new List<Team>
            {
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "G2 Esports",
                    ShortName = "G2",
                    SmallImageUrl = "mini_logo/G2.png",
                    ImageUrl = "logo/G2.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Fnatic",
                    ShortName = "FNC",
                    SmallImageUrl = "mini_logo/FNC.png",
                    ImageUrl = "logo/FNC.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Karmine Corp",
                    ShortName = "KC",
                    SmallImageUrl = "mini_logo/KC.png",
                    ImageUrl = "logo/KC.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Team BDS",
                    ShortName = "BDS",
                    SmallImageUrl = "mini_logo/BDS.png",
                    ImageUrl = "logo/BDS.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "SK Gaming",
                    ShortName = "SK",
                    SmallImageUrl = "mini_logo/SK.png",
                    ImageUrl = "logo/SK.png"
                },new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Team Heretics",
                    ShortName = "TH",
                    SmallImageUrl = "mini_logo/TH.png",
                    ImageUrl = "logo/TH.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Team Vitality",
                    ShortName = "VIT",
                    SmallImageUrl = "mini_logo/VIT.png",
                    ImageUrl = "logo/VIT.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Rogue",
                    ShortName = "RGE",
                    SmallImageUrl = "mini_logo/RGE.png",
                    ImageUrl = "logo/RGE.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "GIANTX",
                    ShortName = "GX",
                    SmallImageUrl = "mini_logo/GX.png",
                    ImageUrl = "logo/GX.png"
                },
                new Team
                {
                    Id = Guid.NewGuid(),
                    Name = "Movistar KOI",
                    ShortName = "MKOI",
                    SmallImageUrl = "mini_logo/MKOI.png",
                    ImageUrl = "logo/MKOI.png"
                },
            };

            #endregion
            #region Players

            var players = new List<Player>
            {
                // G2
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Caps",
                    Name = "RASMUS BORREGAARD WINTHER",
                    ImageUrl = "players/g2/caps.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "G2").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "BrokenBlade",
                    Name = "SERGEN ÇELIK",
                    ImageUrl = "players/g2/brokenblade.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "G2").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Hans Sama",
                    Name = "STEVEN LIV",
                    ImageUrl = "players/g2/hanssama.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "G2").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "SkewMond",
                    Name = "RUDY SEMAAN",
                    ImageUrl = "players/g2/skewmond.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "G2").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Labrov",
                    Name = "LABROS PAPOUTSAKIS",
                    ImageUrl = "players/g2/labrov.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "G2").Id
                },

                // KC
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Vladi",
                    Name = "VLADIMIROS KOURTIDIS",
                    ImageUrl = "players/kc/vladi.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "KC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Canna",
                    Name = "CHANGDONG KIM",
                    ImageUrl = "players/kc/canna.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "KC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Caliste",
                    Name = "CALISTE HENRY-HENNEBERT",
                    ImageUrl = "players/kc/caliste.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "KC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Yike",
                    Name = "MARTIN SUNDELIN",
                    ImageUrl = "players/kc/yike.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "KC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Targamas",
                    Name = "RAPHAEL CRABBÉ",
                    ImageUrl = "players/kc/targamas.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "KC").Id
                },

                // BDS
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "nuc",
                    Name = "ILIAS BIZRIKEN",
                    ImageUrl = "players/bds/nuc.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "BDS").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Irrelevant",
                    Name = "JOEL MIRO SCHAROLL",
                    ImageUrl = "players/bds/irrelevant.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "BDS").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Ice",
                    Name = "SANG-HOON YOON",
                    ImageUrl = "players/bds/ice.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "BDS").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "113",
                    Name = "DOĞUKAN BALCI",
                    ImageUrl = "players/bds/113.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "BDS").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Parus",
                    Name = "POLAT FURKAN ÇIÇEK",
                    ImageUrl = "players/bds/parus.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "BDS").Id
                },

                // FNC
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Humanoid",
                    Name = "MAREK BRÁZDA",
                    ImageUrl = "players/fnc/humanoid.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "FNC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Oscarinin",
                    Name = "OSCAR MUÑOZ JIMÉNEZ",
                    ImageUrl = "players/fnc/oscarinin.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "FNC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Upset",
                    Name = "ELIAS LIPP",
                    ImageUrl = "players/fnc/upset.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "FNC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Razork",
                    Name = "IVÁN MARTÍN",
                    ImageUrl = "players/fnc/razork.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "FNC").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Mikyx",
                    Name = "MIHAEL MEHLE",
                    ImageUrl = "players/fnc/mikyx.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "FNC").Id
                },

                // SK
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "RKR",
                    Name = "STEVEN CHEN",
                    ImageUrl = "players/sk/rkr.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "SK").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "JNX",
                    Name = "JANIK BARTELS",
                    ImageUrl = "players/sk/jnx.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "SK").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Keduii",
                    Name = "TIM WILLERS",
                    ImageUrl = "players/sk/keduii.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "SK").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Boukada",
                    Name = "LAHLOU MEHDI",
                    ImageUrl = "players/sk/boukada.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "SK").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Loopy",
                    Name = "DONGHYEON KIM",
                    ImageUrl = "players/sk/loopy.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "SK").Id
                },

                // TH
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Kamiloo",
                    Name = "HAUDEGOND KAMIL",
                    ImageUrl = "players/th/kamiloo.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "TH").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Carlsen",
                    Name = "CARL ULSTED CARLSEN",
                    ImageUrl = "players/th/carlsen.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "TH").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Flakked",
                    Name = "VICTOR LIROLA",
                    ImageUrl = "players/th/flakked.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "TH").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Sheo",
                    Name = "THÉO BORILE",
                    ImageUrl = "players/th/sheo.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "TH").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Stend",
                    Name = "PAUL LARDIN",
                    ImageUrl = "players/th/stend.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "TH").Id
                },

                // VIT
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Czajek",
                    Name = "MATEUSZ CZAJKA",
                    ImageUrl = "players/vit/czajek.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "VIT").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Naak Nako",
                    Name = "KAAN OKAN",
                    ImageUrl = "players/vit/naaknako.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "VIT").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Carzzy",
                    Name = "MATYÁŠ ORSÁG",
                    ImageUrl = "players/vit/carzzy.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "VIT").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Lyncas",
                    Name = "LINAS NAUNČIKAS",
                    ImageUrl = "players/vit/lyncas.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "VIT").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Nisqy",
                    Name = "YASIN DINCER",
                    ImageUrl = "players/vit/nisqy.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "VIT").Id
                },

                // RGE
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Larssen",
                    Name = "EMIL LARSSON",
                    ImageUrl = "players/rge/larssen.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "RGE").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Adam",
                    Name = "ADAM MAANANE",
                    ImageUrl = "players/rge/adam.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "RGE").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Patrik",
                    Name = "PATRIK JIRU",
                    ImageUrl = "players/rge/patrik.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "RGE").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Malrang",
                    Name = "GEUN-SEONG KIM",
                    ImageUrl = "players/rge/malrang.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "RGE").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Execute",
                    Name = "JEONGHOON LEE",
                    ImageUrl = "players/rge/execute.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "RGE").Id
                },

                // GX
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Jackies",
                    Name = "ADAM JEŘÁBEK",
                    ImageUrl = "players/gx/jackies.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "GX").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Lot",
                    Name = "EREN YILDIZ",
                    ImageUrl = "players/gx/lot.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "GX").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Noah",
                    Name = "HYUNTAEK O",
                    ImageUrl = "players/gx/noah.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "GX").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "ISMA",
                    Name = "ISMAÏL BOUALEM",
                    ImageUrl = "players/gx/isma.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "GX").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Jun",
                    Name = "SEJUN YOON",
                    ImageUrl = "players/gx/jun.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "GX").Id
                },

                // MKOI
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Jojopyun",
                    Name = "JOSEPH JOON PYUN",
                    ImageUrl = "players/mkoi/jojopyun.png",
                    RoleId = roles.First(r => r.Name == "Mid").Id,
                    TeamId = teams.First(t => t.ShortName == "MKOI").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Myrwn",
                    Name = "ÁLEX VILLAREJO PASTOR",
                    ImageUrl = "players/mkoi/myrwn.png",
                    RoleId = roles.First(r => r.Name == "Top").Id,
                    TeamId = teams.First(t => t.ShortName == "MKOI").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Supa",
                    Name = "DAVID MARTÍNEZ GARCÍA",
                    ImageUrl = "players/mkoi/supa.png",
                    RoleId = roles.First(r => r.Name == "AD Carry").Id,
                    TeamId = teams.First(t => t.ShortName == "MKOI").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Elyoya",
                    Name = "JAVIER PRADES",
                    ImageUrl = "players/mkoi/elyoya.png",
                    RoleId = roles.First(r => r.Name == "Jungle").Id,
                    TeamId = teams.First(t => t.ShortName == "MKOI").Id
                },
                new Player
                {
                    Id = Guid.NewGuid(),
                    PlayerName = "Alvaro",
                    Name = "ALVARO FERNÁNDEZ DEL AMO",
                    ImageUrl = "players/mkoi/alvaro.png",
                    RoleId = roles.First(r => r.Name == "Support").Id,
                    TeamId = teams.First(t => t.ShortName == "MKOI").Id
                },

            };

            #endregion
            #region MatchTypes
            var matchTypes = new List<MatchType>
            {
                new MatchType{ Id = Guid.NewGuid(), Name = "Best of 1", RequiredWins = 1, ShortName = "Bo1"},
                new MatchType{ Id = Guid.NewGuid(), Name = "Best of 3", RequiredWins = 2, ShortName = "Bo3"},
                new MatchType{ Id = Guid.NewGuid(), Name = "Best of 5", RequiredWins = 3, ShortName = "Bo5"}
            };
            #endregion

            modelBuilder.Entity<Champion>().HasData(champions);
            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<Player>().HasData(players);
            modelBuilder.Entity<MatchType>().HasData(matchTypes);
        }
    }
}
