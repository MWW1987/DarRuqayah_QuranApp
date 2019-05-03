using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DarRuqayah_QuranApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthTasks",
                columns: table => new
                {
                    MonthTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinalDailyGrade = table.Column<byte>(nullable: false),
                    FinalWeeklyGrade = table.Column<byte>(nullable: false),
                    FinalGrade = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthTasks", x => x.MonthTaskId);
                });

            migrationBuilder.CreateTable(
                name: "Ostads",
                columns: table => new
                {
                    OstadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Tell = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CV = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ostads", x => x.OstadId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Tell = table.Column<string>(nullable: true),
                    ParentTell = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    HefzValue = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    ClassRoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ClassTime = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    OstadId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.ClassRoomId);
                    table.ForeignKey(
                        name: "FK_ClassRooms_Ostads_OstadId",
                        column: x => x.OstadId,
                        principalTable: "Ostads",
                        principalColumn: "OstadId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyTasks",
                columns: table => new
                {
                    DailyTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    DailyHefzValue = table.Column<byte>(nullable: false),
                    GoodBehavier = table.Column<byte>(nullable: false),
                    Hearing = table.Column<byte>(nullable: false),
                    Hefz = table.Column<byte>(nullable: false),
                    NewReapet = table.Column<byte>(nullable: false),
                    OldReapet = table.Column<byte>(nullable: false),
                    OstadId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTasks", x => x.DailyTaskId);
                    table.ForeignKey(
                        name: "FK_DailyTasks_Ostads_OstadId",
                        column: x => x.OstadId,
                        principalTable: "Ostads",
                        principalColumn: "OstadId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DailyTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyTasks",
                columns: table => new
                {
                    WeeklyTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GoodHefz = table.Column<byte>(nullable: false),
                    Tajvid = table.Column<byte>(nullable: false),
                    Ada = table.Column<byte>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    MonthTaskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyTasks", x => x.WeeklyTaskId);
                    table.ForeignKey(
                        name: "FK_WeeklyTasks_MonthTasks_MonthTaskId",
                        column: x => x.MonthTaskId,
                        principalTable: "MonthTasks",
                        principalColumn: "MonthTaskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeeklyTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_OstadId",
                table: "ClassRooms",
                column: "OstadId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyTasks_OstadId",
                table: "DailyTasks",
                column: "OstadId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyTasks_UserId",
                table: "DailyTasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyTasks_MonthTaskId",
                table: "WeeklyTasks",
                column: "MonthTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyTasks_UserId",
                table: "WeeklyTasks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "DailyTasks");

            migrationBuilder.DropTable(
                name: "WeeklyTasks");

            migrationBuilder.DropTable(
                name: "Ostads");

            migrationBuilder.DropTable(
                name: "MonthTasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
