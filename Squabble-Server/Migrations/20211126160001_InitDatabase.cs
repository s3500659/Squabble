using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Squabble.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSso = table.Column<bool>(type: "bit", nullable: false),
                    MicrosoftSsoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunicationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.ServerID);
                });

            migrationBuilder.CreateTable(
                name: "FriendRequests",
                columns: table => new
                {
                    SenderID = table.Column<int>(type: "int", nullable: false),
                    ReceiverID = table.Column<int>(type: "int", nullable: false),
                    FriendRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accepted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendRequests", x => new { x.SenderID, x.ReceiverID });
                    table.ForeignKey(
                        name: "FK_FriendRequests_Accounts_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FriendRequests_Accounts_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FriendID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => new { x.UserID, x.FriendID });
                    table.ForeignKey(
                        name: "FK_Friendships_Accounts_FriendID",
                        column: x => x.FriendID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Friendships_Accounts_UserID",
                        column: x => x.UserID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KanbanItems",
                columns: table => new
                {
                    KanbanItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanbanItems", x => x.KanbanItemID);
                    table.ForeignKey(
                        name: "FK_KanbanItems_Accounts_UserID",
                        column: x => x.UserID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestionOne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SecurityAnswerOne = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SecurityQuestionTwo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SecurityAnswerTwo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => new { x.Email, x.UserName });
                    table.ForeignKey(
                        name: "FK_Logins_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    ChannelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AzureChatThreadId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.ChannelId);
                    table.ForeignKey(
                        name: "FK_Channels_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ServerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServerAdmins",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerAdmins", x => new { x.UserId, x.ServerID });
                    table.ForeignKey(
                        name: "FK_ServerAdmins_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerAdmins_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ServerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerMembers",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerMembers", x => new { x.UserID, x.ServerID });
                    table.ForeignKey(
                        name: "FK_ServerMembers_Accounts_UserID",
                        column: x => x.UserID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerMembers_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ServerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerOwners",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerOwners", x => new { x.UserId, x.ServerID });
                    table.ForeignKey(
                        name: "FK_ServerOwners_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerOwners_Servers_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Servers",
                        principalColumn: "ServerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChannelMembers",
                columns: table => new
                {
                    ChannelId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelMembers", x => new { x.UserID, x.ChannelId });
                    table.ForeignKey(
                        name: "FK_ChannelMembers_Accounts_UserID",
                        column: x => x.UserID,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChannelMembers_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "Avatar", "CommunicationToken", "CommunicationUserId", "Email", "FirstName", "IsSso", "MicrosoftSsoId", "MiddleName", "Surname", "UserName" },
                values: new object[,]
                {
                    { 1, null, "eyJhbGciOiJSUzI1NiIsImtpZCI6IjEwMyIsIng1dCI6Ikc5WVVVTFMwdlpLQTJUNjFGM1dzYWdCdmFMbyIsInR5cCI6IkpXVCJ9.eyJza3lwZWlkIjoiYWNzOjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOF8wMDAwMDAwZC1kZDA4LWQxMzgtNGJmZS05NTNhMGQwMDkyNzAiLCJzY3AiOjE3OTIsImNzaSI6IjE2Mzc5NDIzOTciLCJleHAiOjE2MzgwMjg3OTcsImFjc1Njb3BlIjoiY2hhdCx2b2lwIiwicmVzb3VyY2VJZCI6IjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOCIsImlhdCI6MTYzNzk0MjM5N30.N4SQJYPEZFRLeoQaqWAKdx2g4sGRSbGl6Ak1UvnJEXy2qtwj4E78pkDNWd_xM1QI6AI0N6Fq3uJ5L32Rvhj3-yekOoBPvsZEpS78l776I4LYqR4XLALHKDsMVNnYwLbgvjuiGL3eJq_yfODzqtLoIZOWQyiW5ioKGSLTuEMmJUU3XM_C8cfjSXZ9WEPlQKiCcDppmfQgPIVhn_daKmy4Q4VN-C7IUnxuUiQdx-NNlWqxoxl_csPs1KlXPLmB7lT7fLqJbdIzc977jTQLFRg6c45W4rowAS9B5X5HRAejhs3obA7MvFuq4GcSjAMkc1eTnJCIZ76l1Z5Jj0IZRjdtMw", "8:acs:025fbc48-8ea1-4cb2-959c-42b4dc9e9728_0000000d-dd08-d138-4bfe-953a0d009270", "test1@test.com", "Test", false, null, "Ing", "Dummy", "Dragonborn" },
                    { 2, null, "eyJhbGciOiJSUzI1NiIsImtpZCI6IjEwMyIsIng1dCI6Ikc5WVVVTFMwdlpLQTJUNjFGM1dzYWdCdmFMbyIsInR5cCI6IkpXVCJ9.eyJza3lwZWlkIjoiYWNzOjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOF8wMDAwMDAwZC1kZDA5LTcyZWItNGJmZS05NTNhMGQwMDkyN2EiLCJzY3AiOjE3OTIsImNzaSI6IjE2Mzc5NDIzOTciLCJleHAiOjE2MzgwMjg3OTcsImFjc1Njb3BlIjoiY2hhdCx2b2lwIiwicmVzb3VyY2VJZCI6IjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOCIsImlhdCI6MTYzNzk0MjM5N30.JgUset_wettClxuqDidTKHuc8y_08oeIcStFqMr1rVa8p5YmwloLum_K4fEtCgTHX8cI7CFEOGYY5bSZsJiR-B23VdQXYYQVgUb22CP7GNmSEm_F2uZyXiPcqFElQe3s_GzH96v_dnttC4b6Tma4Sjwao3Pzemn4Vkz-dyk6i3I2Nlb_CdmhCRQ2jDDkgkKiy0Dq8weM_DVqjpJd8YqgWs3S5Na5L2zQ0FC15wx0nz6gbY9F-rE8P2vBaFqFibjtEY4TLsmVi_yA3_VobzTZ6Fgj7KWIiHRDOnN3P0CYSV_KAgn8e--xOegXYpDLDAdu0Ik4e0Cala4g0-y8dtL6Yw", "8:acs:025fbc48-8ea1-4cb2-959c-42b4dc9e9728_0000000d-dd09-72eb-4bfe-953a0d00927a", "test2@test.com", "Flim", false, null, "", "Flam", "Hayzeus" },
                    { 3, null, "eyJhbGciOiJSUzI1NiIsImtpZCI6IjEwMyIsIng1dCI6Ikc5WVVVTFMwdlpLQTJUNjFGM1dzYWdCdmFMbyIsInR5cCI6IkpXVCJ9.eyJza3lwZWlkIjoiYWNzOjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOF8wMDAwMDAwZC1kZDA5LWJkMmQtNGJmZS05NTNhMGQwMDkyN2MiLCJzY3AiOjE3OTIsImNzaSI6IjE2Mzc5NDIzOTgiLCJleHAiOjE2MzgwMjg3OTgsImFjc1Njb3BlIjoiY2hhdCx2b2lwIiwicmVzb3VyY2VJZCI6IjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOCIsImlhdCI6MTYzNzk0MjM5OH0.dusS7seOIx6NmjTA7Za-pNl7ePK4MH-r10rqO3Qv1OxUyPWfYgI7SP2DIWpbbyq3KlT029s5Mmerrefw8ZzWGnzA2GgA7B3Xief7gEzffsYRzZtiKWWwRz0C5AJfl3k0mJm54kZJ12i84Fh_eZmEXlRS5cHTQyCSBPsSVt9wMaGBG34ccL4Z1fiVFIlVv4OOCSMg9FGh07yyq1vc7rlFP-EJoo5pU3atnW6ZAdqjjVSIBB6N_O2b4OfNaMIVHe6Rc7-tFzS-sPTVULeaaMm8AEiPPR17VAImcOZEUkfCzOuJ7rjbeQx_Uj94f8_CDDjR4rBPZyYvcwLBgxHrbujwbQ", "8:acs:025fbc48-8ea1-4cb2-959c-42b4dc9e9728_0000000d-dd09-bd2d-4bfe-953a0d00927c", "test3@test.com", "Bob", false, null, "The", "Builder", "Handyman" },
                    { 4, null, "eyJhbGciOiJSUzI1NiIsImtpZCI6IjEwMyIsIng1dCI6Ikc5WVVVTFMwdlpLQTJUNjFGM1dzYWdCdmFMbyIsInR5cCI6IkpXVCJ9.eyJza3lwZWlkIjoiYWNzOjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOF8wMDAwMDAwZC1kZDBhLTA5ZjItNGJmZS05NTNhMGQwMDkyODAiLCJzY3AiOjE3OTIsImNzaSI6IjE2Mzc5NDIzOTkiLCJleHAiOjE2MzgwMjg3OTksImFjc1Njb3BlIjoiY2hhdCx2b2lwIiwicmVzb3VyY2VJZCI6IjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOCIsImlhdCI6MTYzNzk0MjM5OX0.T_8ajqKKjOrGyvfJonuCgtnvYWSOyc9UhCEt4botBMrkKFYp_SKFArZZ1_vcJckJ1YXEtbLYBCtPYvWD9wXrXwKFw1ucSCCEE8KFBa4FJ-B7PWUEUdfbX7cUo0Yo_s2d1kfF0isHDBuia916w2OeHJvCM6DwXPiu7gbhxh2wiPHu8dLP62RwAtRfnfzjJRDcInhqwWYjgnjMRSmiIFDEloZ-g2G2lMkADbwfgNi3YFwGsYKTwwqjQ-4DTgstU229I-NqpbEhEMGjFb3OJ7M9NYqyeksSIT4rbnpsQ7SfsL-xCuxmkcX9HnxuOZi9nPDNHjfjelgL1RPAFcmBRJEaIQ", "8:acs:025fbc48-8ea1-4cb2-959c-42b4dc9e9728_0000000d-dd0a-09f2-4bfe-953a0d009280", "bikinibottom1@test.com", "Spongebob", false, null, "", "Squarepants", "Spongebob" },
                    { 5, null, "eyJhbGciOiJSUzI1NiIsImtpZCI6IjEwMyIsIng1dCI6Ikc5WVVVTFMwdlpLQTJUNjFGM1dzYWdCdmFMbyIsInR5cCI6IkpXVCJ9.eyJza3lwZWlkIjoiYWNzOjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOF8wMDAwMDAwZC1kZDBhLTQ2YmEtNGJmZS05NTNhMGQwMDkyODIiLCJzY3AiOjE3OTIsImNzaSI6IjE2Mzc5NDIzOTkiLCJleHAiOjE2MzgwMjg3OTksImFjc1Njb3BlIjoiY2hhdCx2b2lwIiwicmVzb3VyY2VJZCI6IjAyNWZiYzQ4LThlYTEtNGNiMi05NTljLTQyYjRkYzllOTcyOCIsImlhdCI6MTYzNzk0MjQwMH0.axECfPzLKwKUEMUTKgW0E2vC1Tkf45TuUzAJFlmFtgLGj1-jmQC92EHktCQp466JKUUmPmGx883aJbCErI3rgaoKq3rTt4Ew_NEbTA1thMC3h_rbHU81n3uOp1_Uujq-0BEeC8u3QvJEgBp6FfMVOhTqPmoutaTkuDNMTGwI97liXGhUDFlI7z_HfUssRBUQThYPlIlXpDOOmGFVXaPlrHDPQpHl9h7BdovbSUPK_-bf7AyRIIjbEQqggJlUHDjMsgRf5vvJYnIYX0yhZPY1ksOVci7SD7z6m9jW47kJNpcMs9BNwRCUzYYvHBGOGfQP7_UMySFL41ruRJXtH9M0Qw", "8:acs:025fbc48-8ea1-4cb2-959c-42b4dc9e9728_0000000d-dd0a-46ba-4bfe-953a0d009282", "bikinibottom2@test.com", "Squidward", false, null, "", "Tentacles", "Squidward" }
                });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "ChannelId", "AzureChatThreadId", "ChannelName", "ServerID" },
                values: new object[] { 2, "19:v4z-VSpQNysbuapG1LFWzeX4MkdpI7r0eSmUI1MjAqM1@thread.v2", "1-2", null });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "ServerID", "ServerName" },
                values: new object[] { 1, "Test server :)" });

            migrationBuilder.InsertData(
                table: "ChannelMembers",
                columns: new[] { "ChannelId", "UserID" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "ChannelId", "AzureChatThreadId", "ChannelName", "ServerID" },
                values: new object[] { 1, "19:72GBN-_cGQFjcBmNJPea-Cht8fJn0bl8UoH7Wvjx9NM1@thread.v2", "Test Channel", 1 });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "FriendID", "UserID" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Email", "UserName", "AccountId", "PasswordHash", "SecurityAnswerOne", "SecurityAnswerTwo", "SecurityQuestionOne", "SecurityQuestionTwo" },
                values: new object[,]
                {
                    { "test1@test.com", "Dragonborn", 1, "E4NfjW+2HwFr5GAD8l5X5rFhCVoV80p0/H+yD194tYkrxlRvavi4QwdzAUOQ8oeG", "b/lLVjItbp3MDpeq+UZ8Uxq3vlLwr7HfctKPPS5yMcRDiB8JiYy6+ItwEkWrPfo+", "NWfsavEWqbP3bv2BJ7ZddslQ5AG/5934nA9Ey+VGXrXy37frZl+41o0fp1k60UME", "My first pet's name?", "My second pet's name?" },
                    { "test2@test.com", "Hayzeus", 2, "fVl4qgE1l2CWN97Bm+UQdfyxu/CngZxNeun5mSnLZETuCWu0TW2cf2CxSZYG67N2", "G+cwgQ1b5R2AFB7Q1jNI9HuqxXitim1tm9uhqXmtDk3RtSIxTPNkjTafRaGgmIUJ", "NWI2aBBnuEatlXk71c+AhLI5ORdWljjs0C7Tbyc1tycWfRXrX/Tmxn0/gsNUFFL5", "My first pet's name?", "My second pet's name?" },
                    { "test3@test.com", "Handyman", 3, "X/mIqEqIMmgcIVfkR0TZwqzT91eASaPJ9B4uW6FWb8Fv2FGzH2GBsYcmljfTDg0m", "74mm5Bl9FOiCPZiEjG8JXOS1oVBnxZA8xZWfQh/d3P7A3SwqdcySVwS2wNpePBNK", "S5/9BNrAiO63+EyoMD+qQ5h4S5ImRcft3G6JY4g/saWHml8V2Kf0Tc+FhWd0+2Uo", "My first pet's name?", "My second pet's name?" },
                    { "bikinibottom1@test.com", "Spongebob", 4, "Rph6QCIDFUXeBeO/bzoz1GHhfektxxK2otpPlGVaMjSCsA3v94xsSW5eQp8fJatL", "D/4BXLY97RrlWB1sZkpiaENp6fZ0jFI7MfXSkr0gjGxi94EjmFAjnE8wFtXXpYPK", "3YmO+y/WuyZnulabttK9LV08zfzHEg6C5xU4NoEOBCw0O5FrW8kiM+9xgjLlU5e6", "My first pet's name?", "My second pet's name?" },
                    { "bikinibottom2@test.com", "Squidward", 5, "ImjptL4PWrb8qn++FxpTGE9t2sU6+69ZYwzdgrmNjRH/DQE0w3AdsJy6xEdoiOdg", "BQHhzeispQfU1HKBGRDt9v4k4WKEEYjUBoqt2h6kq4JngdlLUm4H129Q85GJ7ssk", "qCSilrG7z5ak710pWGYHCNasyyP4d6I5/NpKtS1XtD2mRwoBrHNoWFW6kGTvg342", "My first pet's name?", "My second pet's name?" }
                });

            migrationBuilder.InsertData(
                table: "ServerAdmins",
                columns: new[] { "ServerID", "UserId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "ServerMembers",
                columns: new[] { "ServerID", "UserID" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "ServerOwners",
                columns: new[] { "ServerID", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ChannelMembers_ChannelId",
                table: "ChannelMembers",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Channels_ServerID",
                table: "Channels",
                column: "ServerID");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequests_ReceiverID",
                table: "FriendRequests",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_FriendID",
                table: "Friendships",
                column: "FriendID");

            migrationBuilder.CreateIndex(
                name: "IX_KanbanItems_UserID",
                table: "KanbanItems",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_AccountId",
                table: "Logins",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ChannelId",
                table: "Posts",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAdmins_ServerID",
                table: "ServerAdmins",
                column: "ServerID");

            migrationBuilder.CreateIndex(
                name: "IX_ServerMembers_ServerID",
                table: "ServerMembers",
                column: "ServerID");

            migrationBuilder.CreateIndex(
                name: "IX_ServerOwners_ServerID",
                table: "ServerOwners",
                column: "ServerID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChannelMembers");

            migrationBuilder.DropTable(
                name: "FriendRequests");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "KanbanItems");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "ServerAdmins");

            migrationBuilder.DropTable(
                name: "ServerMembers");

            migrationBuilder.DropTable(
                name: "ServerOwners");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
