using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredWins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmallImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MatchTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BlueTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RedTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BlueTeamWins = table.Column<int>(type: "int", nullable: false),
                    RedTeamWins = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_MatchTypes_MatchTypeId",
                        column: x => x.MatchTypeId,
                        principalTable: "MatchTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Matches_Teams_BlueTeamId",
                        column: x => x.BlueTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Matches_Teams_RedTeamId",
                        column: x => x.RedTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("003ba693-afc2-4b48-ba37-21469aeb6eb1"), "Zac" },
                    { new Guid("006f5784-e423-4865-842c-86f5fe843222"), "Draven" },
                    { new Guid("0245ce2b-e68f-4a60-9526-2152e40038cf"), "Nidalee" },
                    { new Guid("03bc9130-b1d8-4545-bc18-144ca15d2583"), "Syndra" },
                    { new Guid("0c067046-9fcf-4305-acb8-a22a3ba127c2"), "Zyra" },
                    { new Guid("0e1229c9-ac97-4845-b40e-91bff4bdb4ad"), "Thresh" },
                    { new Guid("11486d38-2b5e-43cc-ba53-25f8ef3c4ecd"), "Shen" },
                    { new Guid("12967cbc-b67f-440d-aadd-04069dac6059"), "Shaco" },
                    { new Guid("12abe70c-e79c-4564-8ce8-96641e874f80"), "Gnar" },
                    { new Guid("12c61921-5507-48cf-b74a-8dc3c2289257"), "Irelia" },
                    { new Guid("12e9ae8b-9dc8-4fc6-a6d7-58f0c3fc4de2"), "Leblanc" },
                    { new Guid("14656281-7cbb-4bfb-bc48-76cbcaec258c"), "Illaoi" },
                    { new Guid("164baa8d-bd1c-4afa-8efd-db57548351f4"), "Twisted Fate" },
                    { new Guid("191b9cb2-ae6d-472c-a56d-adc0c2137432"), "Lillia" },
                    { new Guid("1b73078c-b31f-4d02-a461-2e98f688e5d5"), "Xerath" },
                    { new Guid("1d346a0a-337d-46f3-853f-7c58ef91b7c9"), "Talon" },
                    { new Guid("1dfed61b-2de2-4892-833d-304126817eb5"), "Kayn" },
                    { new Guid("1e6adb7c-47e6-4205-a3fb-6a74c69fdd59"), "Kindred" },
                    { new Guid("1fe79fd7-e8d7-4b31-8ef4-a632803655bb"), "Kaisa" },
                    { new Guid("203b1aee-a967-496a-b0df-2054126af6b0"), "Ezreal" },
                    { new Guid("242235e1-6b91-49ce-a674-3ae5493c9c2f"), "Zoe" },
                    { new Guid("25025704-b7a5-4953-a5a6-c3b4a5378faa"), "Sona" },
                    { new Guid("258e8a21-bff1-4092-9556-a7562ab5f5e9"), "Bard" },
                    { new Guid("284a2eef-95ef-49d0-a3b0-ac70776b4dae"), "Zed" },
                    { new Guid("28ae9c8c-cea2-4f83-a2d4-ef98202f80bc"), "Rammus" },
                    { new Guid("2bd19bf2-844c-4ad1-a502-6f350c6b1131"), "Shyvana" },
                    { new Guid("2e63a3fe-2981-4e5f-860c-2f627176b4d3"), "Garen" },
                    { new Guid("2ec5b7a4-d619-42ea-8b6e-00432689dc51"), "Rakan" },
                    { new Guid("32ac4a0f-7a7a-4323-9e64-765c20826cb6"), "Cassiopeia" },
                    { new Guid("3525f601-f20a-4c0f-94e8-b16edc0f3dfc"), "Jayce" },
                    { new Guid("37754b85-c6ef-4103-9381-f69782cbe400"), "Jarvan IV" },
                    { new Guid("3b95267c-8c1e-46b9-870f-62390c123c48"), "Nami" },
                    { new Guid("3d52f607-3ef8-4f48-8a24-5f4aa66d087f"), "Veigar" },
                    { new Guid("3d71164e-a8a0-4741-b677-62930528df9b"), "Nautilus" },
                    { new Guid("3f073e85-a647-41fe-91ef-598d48317606"), "Yasuo" },
                    { new Guid("3f0b2ba0-aca4-4fb7-bf6f-99948832ea97"), "Karma" },
                    { new Guid("4102221d-9bbe-4f1e-8708-a164c44562a4"), "Malphite" },
                    { new Guid("429fae04-b83a-4930-b975-65502dfc2c5a"), "Annie" },
                    { new Guid("460121c7-a869-4bb1-a555-32e12b4cb679"), "Nocturne" },
                    { new Guid("463a937d-c1d2-4c29-bd19-b68735724f15"), "Taliyah" },
                    { new Guid("46db4fa1-6a48-45ce-955c-b6def3e09651"), "Anivia" },
                    { new Guid("46fcdc70-94bf-475d-a8f7-421ef11ef2e7"), "Gragas" },
                    { new Guid("4b1cc565-9f3f-4634-bee5-b5632be42dcb"), "Aphelios" },
                    { new Guid("4ec9b3ef-f4cb-486c-b54d-6449c160c53e"), "Nunu" },
                    { new Guid("51c3e242-d433-4ef7-a1d3-9e6bb191ecb1"), "Jinx" },
                    { new Guid("5234c08e-5dac-49f1-a7fc-998018971ee0"), "Katarina" },
                    { new Guid("52f7d021-1391-456f-8f8a-2a0d9c41d301"), "Master Yi" },
                    { new Guid("57c717ff-6a83-4dd6-bfd5-b98950ed47e0"), "Xin Zhao" },
                    { new Guid("593a13de-891b-4f0b-9a09-b43c8c6be644"), "Jax" },
                    { new Guid("593a4e5a-8dd3-45ad-90cd-7fc411dee77c"), "Akali" },
                    { new Guid("5b0f672c-333c-4d74-a16f-fa991efbcdb0"), "Kennen" },
                    { new Guid("5b49a822-85fa-4148-a328-a6feb96f7794"), "Lucian" },
                    { new Guid("5cb4a3d7-13d7-4ec6-b313-08ab023de9b9"), "Lulu" },
                    { new Guid("5f0928f1-9a83-4253-b7c5-334f3427f759"), "Tahm Kench" },
                    { new Guid("616162f8-daed-4ac2-b015-9002b080c64e"), "Neeko" },
                    { new Guid("647ba38f-4556-46f7-8a81-19d358dcedca"), "Braum" },
                    { new Guid("650b5f4a-72fb-48fd-9935-6cfbe4cfb7e3"), "Qiyana" },
                    { new Guid("658d53a1-7657-48b9-8821-d42a97c135d2"), "Teemo" },
                    { new Guid("65dee88c-3614-4dda-ace0-de99b330c412"), "Lee Sin" },
                    { new Guid("66560c01-1b2a-4c99-a7f3-7ba1b3caa22c"), "Jhin" },
                    { new Guid("67091be8-3307-4fe3-85d7-0fda410eb524"), "Orianna" },
                    { new Guid("68475ad7-7d92-4d0f-886b-4b6065d3ce1a"), "Graves" },
                    { new Guid("6961aa71-4a52-4db3-84e5-326b6addc924"), "Galio" },
                    { new Guid("696daffe-9fd7-41ea-8ec0-6ab68db989a9"), "RekSai" },
                    { new Guid("6a1f3bf4-b784-45f6-a1b2-509c59d5b039"), "Dr Mundo" },
                    { new Guid("6b38cb54-6f70-45ae-a83f-856c1dad94a2"), "Yone" },
                    { new Guid("6c103c67-a63d-4d59-b99e-e16d239a7012"), "Ornn" },
                    { new Guid("6f381c31-af72-4941-ae02-8801e73c44d8"), "Camille" },
                    { new Guid("70ef3ad1-d403-4258-87f2-c669d78b2ba8"), "Fiddlesticks" },
                    { new Guid("71d6a923-716d-4342-af5a-4bc927c6a3c3"), "Renekton" },
                    { new Guid("72322092-cd7b-46bd-b7af-e6b17b13185d"), "Quinn" },
                    { new Guid("73d7bb52-78ad-47a8-8f2f-73caf1e59aa8"), "Zilean" },
                    { new Guid("753d4e43-3c87-43f6-b558-1abfea161b6b"), "Tristana" },
                    { new Guid("7621134e-033a-40a3-be46-f3136da770c4"), "Olaf" },
                    { new Guid("7622ec5b-af04-491f-9fe5-53298fa0793d"), "Nasus" },
                    { new Guid("79887249-eadb-46a9-b1b1-745ccf676198"), "Vayne" },
                    { new Guid("7a112947-7ecf-4f19-836f-918890a6326c"), "Hecarim" },
                    { new Guid("7c0c0caa-c266-4870-b95c-de0403cf1678"), "Sivir" },
                    { new Guid("7c26a7dd-dcbe-4fdc-836f-046af9cec1bd"), "Evelynn" },
                    { new Guid("7cbee14c-da44-4160-b921-0097379b7cb5"), "Aatrox" },
                    { new Guid("7cc8268b-72b9-4d52-9f50-97db9d550769"), "Khazix" },
                    { new Guid("857b35d5-43f5-453c-9beb-77c03b4e15dc"), "Soraka" },
                    { new Guid("85d600c8-038b-41de-b8cc-077c07e5735d"), "Elise" },
                    { new Guid("87855bd4-0121-4c33-8683-e7798f756c56"), "Mordekaiser" },
                    { new Guid("8933fc8d-3753-4fcc-817b-e8ee1960b934"), "Caitlyn" },
                    { new Guid("8c590d2d-71cb-4405-8be2-2ab396382a6c"), "Lux" },
                    { new Guid("8eb5ed80-0c44-41c7-ace1-17b27b07ff47"), "Fiora" },
                    { new Guid("9000e723-e7ae-4750-ad91-624b5147323a"), "Kled" },
                    { new Guid("90401b9f-4b2b-4b7e-a5bf-75403e174f7f"), "Alistar" },
                    { new Guid("90c2a07d-6843-457d-b173-0ed34b963f2f"), "Brand" },
                    { new Guid("943b11fa-4757-48ba-925d-699dccd25645"), "Warwick" },
                    { new Guid("97f3544d-2af5-4eaa-bb4f-f616d4b0c236"), "Senna" },
                    { new Guid("9c712da0-eec2-4a67-8d0e-02488f26a191"), "Swain" },
                    { new Guid("9cbc4f2c-598d-4489-94ee-53491cbc6a39"), "Volibear" },
                    { new Guid("9df7d9da-fafe-4f97-bbdd-4682eac31dd9"), "Miss Fortune" },
                    { new Guid("9ea5eafd-d0f8-4609-8063-d92569302537"), "Pyke" },
                    { new Guid("9fa9c5ac-d70d-48e7-8b94-d5146116868f"), "Viktor" },
                    { new Guid("9fcec9fd-f46b-4c1c-8d36-06bcc950197f"), "Kog Maw" },
                    { new Guid("a0aed77d-02ae-4c1c-baa8-a083c5f17eb7"), "Cho gath" },
                    { new Guid("a1ff0caf-ddcd-4134-8e2d-342185047466"), "Amumu" },
                    { new Guid("a2a4c821-dd5c-4b3a-b4ed-c4be5903bdae"), "Taric" },
                    { new Guid("a41a3bcc-3e6d-412c-9b73-48c57974e480"), "Kalista" },
                    { new Guid("a4ebd866-5c64-43bf-a14b-71dabcb4f634"), "Rumble" },
                    { new Guid("ac530e99-3b6c-4ea1-88d9-6fcbb539d433"), "Yuumi" },
                    { new Guid("ae3525ec-0d4d-4fab-b47e-201d8e3f2956"), "Vi" },
                    { new Guid("af3a6744-c3de-47c9-a91c-6b0713b378e3"), "Tryndamere" },
                    { new Guid("b575d302-9d6c-4064-8e0a-c1cfe423d65a"), "Urgot" },
                    { new Guid("b5e08a69-7745-4089-a871-e86cfc21bbef"), "Corki" },
                    { new Guid("b6ccedf7-5714-4933-ab26-b99010d48919"), "Skarner" },
                    { new Guid("b7e41fdf-76d0-4fcf-afd7-d3008a65fbfa"), "Ashe" },
                    { new Guid("b7ec3e94-6046-4067-8319-a24b2771fe1d"), "Janna" },
                    { new Guid("b837f45b-f5c2-4a5e-8347-97a95cf0a1f1"), "Morgana" },
                    { new Guid("b9af01cf-1470-4c30-b996-1ad1737db252"), "Ryze" },
                    { new Guid("bd2a1d29-7746-4cd6-b19b-9376dfe1be3d"), "Xayah" },
                    { new Guid("c20c9190-a063-486e-a859-1ca5fb258c15"), "Vladimir" },
                    { new Guid("c55083b7-9ffb-4123-91d8-6b8e8cd34b7d"), "Azir" },
                    { new Guid("c5cf3bf7-5ebd-4f2d-adb2-aaf6a3137183"), "Kassadin" },
                    { new Guid("c60ba8b5-cf92-4e29-b296-33277452921d"), "Monkey King" },
                    { new Guid("c63f5d99-3512-4287-8982-94b4788b5884"), "Sejuani" },
                    { new Guid("c6a2b938-c6a4-42f3-88dc-7c117a1eff92"), "Ivern" },
                    { new Guid("c7617c43-25d2-44d7-b62c-d24aba9672a3"), "Ziggs" },
                    { new Guid("ca297559-9a5b-4a59-a845-6b570433f696"), "Kayle" },
                    { new Guid("cc16844b-4746-46ab-aa4c-c0491a9cd4d5"), "Aurelion Sol" },
                    { new Guid("cd385246-5306-495e-adab-53def2621b2a"), "Pantheon" },
                    { new Guid("ce2706d4-1aa2-4912-921e-5f36fcf70ba2"), "Yorick" },
                    { new Guid("cee0c5c6-249e-4b23-9e50-63eb3cc2661c"), "Twitch" },
                    { new Guid("cfcd7e49-33c7-47e6-9ff9-a842a2b9cddb"), "Heimerdinger" },
                    { new Guid("d3149aa1-503b-44dc-841b-179bdd1c629f"), "Seraphine" },
                    { new Guid("d3d71f49-b71c-4238-97fc-91bd0e7ec333"), "Velkoz" },
                    { new Guid("d502ab17-9080-4720-9b86-d8735089d8d2"), "Rengar" },
                    { new Guid("d53b0db1-88be-462d-8257-3b8a9caa03a8"), "Poppy" },
                    { new Guid("da1280d8-bcf5-47c6-a4e2-30934d94c9ea"), "Maokai" },
                    { new Guid("da903bd1-ac49-4111-8f93-a31ac11014b4"), "Lissandra" },
                    { new Guid("df6046ca-f59d-4d45-8d18-8f02bcf0867b"), "Singed" },
                    { new Guid("e17e1460-e901-4ba2-b4a7-e388c2cfbe5d"), "Darius" },
                    { new Guid("e562e40c-5fca-45ea-9645-137385743cff"), "Udyr" },
                    { new Guid("e5e37e00-c074-46ed-b64f-bc6fbdb42da4"), "Varus" },
                    { new Guid("e621f670-4e96-4ede-a16c-a82bd9ec43ca"), "Sion" },
                    { new Guid("e68ba343-42bf-4b9f-b74f-44c31f79eb81"), "Sylas" },
                    { new Guid("e6cf0389-1fa0-4169-a54f-9874b80e0eda"), "Karthus" },
                    { new Guid("e95384b9-a572-4920-af48-f6e8dd9cdd5a"), "Blitzcrank" },
                    { new Guid("eb2e9ad7-c24d-442d-b98e-4b991d4b360d"), "Ahri" },
                    { new Guid("eb4d5c8a-2701-4116-b6f7-82f4e1a2dc2d"), "Diana" },
                    { new Guid("ed2f91fa-d413-4c7a-9773-2f4589b488d4"), "Riven" },
                    { new Guid("f0134760-eebb-4ba2-9d49-f9506ff90e80"), "Trundle" },
                    { new Guid("f0ca12a6-d2a3-49af-ba60-1092c7ad7d68"), "Fizz" },
                    { new Guid("f0fcf713-75ac-4cec-a45b-d438c3acf490"), "Leona" },
                    { new Guid("f32a5f1a-283c-40ab-817f-04b547d75a3b"), "Gangplank" },
                    { new Guid("f72d4e78-d3f6-4067-8eb4-720ced59f5f1"), "Samira" },
                    { new Guid("f96efc56-771c-45a7-bd07-a49d645b7964"), "Malzahar" },
                    { new Guid("fc4d740b-7595-4c07-a0ab-95e786105992"), "Sett" },
                    { new Guid("fd25f55d-85e5-4de9-919a-f0282694c8c9"), "Ekko" }
                });

            migrationBuilder.InsertData(
                table: "MatchTypes",
                columns: new[] { "Id", "Name", "RequiredWins", "ShortName" },
                values: new object[,]
                {
                    { new Guid("01969dca-7362-42c6-87cd-44d9d97b9e7c"), "Best of 3", 2, "Bo3" },
                    { new Guid("30ff682c-c3c1-4bfe-ae02-73f385ce3825"), "Best of 5", 3, "Bo5" },
                    { new Guid("647be9e1-73de-4780-aad7-fdd124f688e3"), "Best of 1", 1, "Bo1" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ImageUrl", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), "top.svg", "Top", 1 },
                    { new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), "jungle.svg", "Jungle", 2 },
                    { new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), "support.svg", "Support", 5 },
                    { new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), "mid.svg", "Mid", 3 },
                    { new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), "carry.svg", "AD Carry", 4 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "ImageUrl", "Losses", "Name", "ShortName", "SmallImageUrl", "Wins" },
                values: new object[,]
                {
                    { new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85"), "logo/MKOI.png", 0, "Movistar KOI", "MKOI", "mini_logo/MKOI.png", 0 },
                    { new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6"), "logo/TH.png", 0, "Team Heretics", "TH", "mini_logo/TH.png", 0 },
                    { new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8"), "logo/FNC.png", 0, "Fnatic", "FNC", "mini_logo/FNC.png", 0 },
                    { new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb"), "logo/BDS.png", 0, "Team BDS", "BDS", "mini_logo/BDS.png", 0 },
                    { new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3"), "logo/RGE.png", 0, "Rogue", "RGE", "mini_logo/RGE.png", 0 },
                    { new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0"), "logo/GX.png", 0, "GIANTX", "GX", "mini_logo/GX.png", 0 },
                    { new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a"), "logo/SK.png", 0, "SK Gaming", "SK", "mini_logo/SK.png", 0 },
                    { new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2"), "logo/G2.png", 0, "G2 Esports", "G2", "mini_logo/G2.png", 0 },
                    { new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d"), "logo/KC.png", 0, "Karmine Corp", "KC", "mini_logo/KC.png", 0 },
                    { new Guid("efea880f-4c15-43e5-b854-e536456e2594"), "logo/VIT.png", 0, "Team Vitality", "VIT", "mini_logo/VIT.png", 0 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "ImageUrl", "Name", "PlayerName", "RoleId", "TeamId" },
                values: new object[,]
                {
                    { new Guid("08781b03-07fa-4048-94ec-b7e98ff7cac1"), "players/bds/parus.png", "POLAT FURKAN ÇIÇEK", "Parus", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb") },
                    { new Guid("1f4d1bea-35d8-4fbf-8345-529b94a3b0a7"), "players/g2/skewmond.png", "RUDY SEMAAN", "SkewMond", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2") },
                    { new Guid("215c0f00-14a7-415a-97ad-936fa0d62821"), "players/fnc/upset.png", "ELIAS LIPP", "Upset", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8") },
                    { new Guid("2baf0fcc-fce2-40a3-9cc1-56b77bb4a733"), "players/g2/labrov.png", "LABROS PAPOUTSAKIS", "Labrov", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2") },
                    { new Guid("34e4be6d-d7ab-4caa-8316-f0814f70ff97"), "players/g2/brokenblade.png", "SERGEN ÇELIK", "BrokenBlade", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2") },
                    { new Guid("3afcbb53-f147-44fc-a1f7-bf51a614ced9"), "players/rge/larssen.png", "EMIL LARSSON", "Larssen", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3") },
                    { new Guid("3b2c5685-3f76-482a-92e8-a72fab088fae"), "players/kc/vladi.png", "VLADIMIROS KOURTIDIS", "Vladi", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d") },
                    { new Guid("3c6f9746-7c4a-4524-97ce-6f49b5171016"), "players/rge/adam.png", "ADAM MAANANE", "Adam", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3") },
                    { new Guid("3cb2311b-24d0-4cfd-be95-5d66fe700273"), "players/bds/irrelevant.png", "JOEL MIRO SCHAROLL", "Irrelevant", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb") },
                    { new Guid("40204dcb-8305-47a2-ad7c-98e69c8c73ff"), "players/kc/targamas.png", "RAPHAEL CRABBÉ", "Targamas", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d") },
                    { new Guid("40a79e5e-945e-4400-921f-648472503a0e"), "players/gx/isma.png", "ISMAÏL BOUALEM", "ISMA", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0") },
                    { new Guid("4604f22e-c682-44f9-8511-ad6082504e0d"), "players/gx/jun.png", "SEJUN YOON", "Jun", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0") },
                    { new Guid("52dfc1a6-7fa2-4071-8e4f-4634b8222a6d"), "players/vit/czajek.png", "MATEUSZ CZAJKA", "Czajek", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("efea880f-4c15-43e5-b854-e536456e2594") },
                    { new Guid("55289d69-db2c-4e79-baed-2e21de163e7a"), "players/sk/boukada.png", "LAHLOU MEHDI", "Boukada", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a") },
                    { new Guid("57240304-b77e-43ce-a50b-974106da95d1"), "players/vit/carzzy.png", "MATYÁŠ ORSÁG", "Carzzy", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("efea880f-4c15-43e5-b854-e536456e2594") },
                    { new Guid("57259fc4-da63-4f1b-996f-b4d511ff571f"), "players/g2/hanssama.png", "STEVEN LIV", "Hans Sama", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2") },
                    { new Guid("59847add-41ff-45c9-b3b4-42cedf23ff04"), "players/rge/patrik.png", "PATRIK JIRU", "Patrik", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3") },
                    { new Guid("5c7323b8-250a-483c-89a0-40618ce8377a"), "players/rge/malrang.png", "GEUN-SEONG KIM", "Malrang", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3") },
                    { new Guid("63ab2d43-3714-488b-a092-4519cfbd35c8"), "players/th/sheo.png", "THÉO BORILE", "Sheo", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6") },
                    { new Guid("671edc91-4c8e-428d-9a6b-29f397a09d50"), "players/sk/rkr.png", "STEVEN CHEN", "RKR", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a") },
                    { new Guid("67631fa2-39ad-4009-88ba-9dfcae1b031d"), "players/vit/nisqy.png", "YASIN DINCER", "Nisqy", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("efea880f-4c15-43e5-b854-e536456e2594") },
                    { new Guid("691df01e-bb62-4710-89e3-e2bb9958e8e7"), "players/vit/lyncas.png", "LINAS NAUNČIKAS", "Lyncas", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("efea880f-4c15-43e5-b854-e536456e2594") },
                    { new Guid("70efc730-07f0-4b35-b9e3-8219c5b04820"), "players/mkoi/alvaro.png", "ALVARO FERNÁNDEZ DEL AMO", "Alvaro", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85") },
                    { new Guid("82a8d52a-c8cc-4de5-b654-18f6cebdc37c"), "players/fnc/oscarinin.png", "OSCAR MUÑOZ JIMÉNEZ", "Oscarinin", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8") },
                    { new Guid("843dcc7f-547c-4ed5-b402-cac81927fcc6"), "players/gx/jackies.png", "ADAM JEŘÁBEK", "Jackies", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0") },
                    { new Guid("8bdd1dc5-7cf5-4516-a3f8-abe744cda839"), "players/fnc/razork.png", "IVÁN MARTÍN", "Razork", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8") },
                    { new Guid("90d43f7f-99c0-4f95-b657-079cc4a89288"), "players/kc/canna.png", "CHANGDONG KIM", "Canna", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d") },
                    { new Guid("90d9353b-69cd-4e50-b885-68b0f0021294"), "players/th/stend.png", "PAUL LARDIN", "Stend", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6") },
                    { new Guid("9b7f753a-26b8-4869-9292-19ca0962e36c"), "players/rge/execute.png", "JEONGHOON LEE", "Execute", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("91c02af7-180e-49c8-a277-33c0fcf38be3") },
                    { new Guid("9cfb9ca2-14df-4c2b-ab8a-3e0d1672a9ac"), "players/fnc/humanoid.png", "MAREK BRÁZDA", "Humanoid", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8") },
                    { new Guid("9e244023-4dc1-46a6-b605-916638ef321f"), "players/th/kamiloo.png", "HAUDEGOND KAMIL", "Kamiloo", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6") },
                    { new Guid("a386531a-3909-4384-a11f-6ff1f9491b55"), "players/fnc/mikyx.png", "MIHAEL MEHLE", "Mikyx", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("51cd5842-b00f-4b87-b985-0ce797e61ce8") },
                    { new Guid("a645ea51-2c88-4f4f-baf8-907550d3ccdd"), "players/g2/caps.png", "RASMUS BORREGAARD WINTHER", "Caps", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("c8a8b7f1-33f5-4f96-b1d5-59286c0eb3a2") },
                    { new Guid("ab169580-fd4a-4ed6-ba86-f1faf0fc7f1b"), "players/kc/caliste.png", "CALISTE HENRY-HENNEBERT", "Caliste", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d") },
                    { new Guid("ac9c6a44-4990-446a-be7b-fc34e82a01fc"), "players/bds/ice.png", "SANG-HOON YOON", "Ice", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb") },
                    { new Guid("acfaf5ce-7b84-46f9-b2cf-039e40a05a69"), "players/mkoi/jojopyun.png", "JOSEPH JOON PYUN", "Jojopyun", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85") },
                    { new Guid("ad04396f-d9f5-4946-aeb6-33a199344eb4"), "players/sk/keduii.png", "TIM WILLERS", "Keduii", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a") },
                    { new Guid("b09e9b3b-d7de-400f-937d-1f7e13cd446e"), "players/th/flakked.png", "VICTOR LIROLA", "Flakked", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6") },
                    { new Guid("b722a870-cc72-406e-a56c-ce6438ef8ebd"), "players/mkoi/myrwn.png", "ÁLEX VILLAREJO PASTOR", "Myrwn", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85") },
                    { new Guid("bacf759f-c097-44c6-85fa-f0b2e54ac5f6"), "players/sk/jnx.png", "JANIK BARTELS", "JNX", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a") },
                    { new Guid("c0c04ac0-2b1a-4dd6-8976-188cd0550481"), "players/bds/nuc.png", "ILIAS BIZRIKEN", "nuc", new Guid("b580ae0b-24af-4c47-ab4f-01bd4063b43b"), new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb") },
                    { new Guid("c71976c1-46ba-4831-a08f-888231875ce5"), "players/kc/yike.png", "MARTIN SUNDELIN", "Yike", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("d5206d52-d495-4b2a-af8d-ea3eb5bf2e4d") },
                    { new Guid("cc843fc8-d5e0-4e24-9b9b-2d4a7765a8af"), "players/gx/noah.png", "HYUNTAEK O", "Noah", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0") },
                    { new Guid("e056d564-dc49-46b6-9440-744a755c796e"), "players/mkoi/supa.png", "DAVID MARTÍNEZ GARCÍA", "Supa", new Guid("bc38e99b-85b8-4c62-8df0-fea42d734984"), new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85") },
                    { new Guid("e0f41f94-21a4-4dd6-a76a-355d4c5a2f50"), "players/th/carlsen.png", "CARL ULSTED CARLSEN", "Carlsen", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("2dc1a206-84cf-4e83-b732-b89a052a41f6") },
                    { new Guid("ef328d8d-fabd-426f-ae86-fec72a65daef"), "players/bds/113.png", "DOĞUKAN BALCI", "113", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("89c913b2-be0d-48eb-924c-7ff4831a5ebb") },
                    { new Guid("f021a7a6-f4d1-4e9b-9d2e-356b55b4c9db"), "players/gx/lot.png", "EREN YILDIZ", "Lot", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("93cb0b9b-b929-48ef-bbfb-2cf6d66a6de0") },
                    { new Guid("f0d4d9a7-685f-4de4-be51-61ef7c0567d0"), "players/vit/naaknako.png", "KAAN OKAN", "Naak Nako", new Guid("1fe1ed1b-5b07-4421-b6db-ceda19c1530d"), new Guid("efea880f-4c15-43e5-b854-e536456e2594") },
                    { new Guid("f6b64cc1-cf70-4270-86b9-012675f92c4f"), "players/sk/loopy.png", "DONGHYEON KIM", "Loopy", new Guid("a9ba8fa3-84ff-4333-94ad-cf0f7a1dac86"), new Guid("987408c0-6ed1-4e2d-a4f1-bb109d33d32a") },
                    { new Guid("f90821dc-8fed-4cc3-85ab-d1751de2bf79"), "players/mkoi/elyoya.png", "JAVIER PRADES", "Elyoya", new Guid("790e51b8-259b-4d36-b5f1-131c41128234"), new Guid("1aa42b46-ac0b-439b-b1f6-1bcddb4fcc85") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_BlueTeamId",
                table: "Matches",
                column: "BlueTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MatchTypeId",
                table: "Matches",
                column: "MatchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RedTeamId",
                table: "Matches",
                column: "RedTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_RoleId",
                table: "Players",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "MatchTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
