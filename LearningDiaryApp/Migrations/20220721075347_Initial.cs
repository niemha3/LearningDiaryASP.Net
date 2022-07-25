using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningDiaryApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TimeToMaster = table.Column<double>(nullable: true),
                    TimeSpent = table.Column<double>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    StartLearningDate = table.Column<DateTime>(nullable: true),
                    CompletitionDate = table.Column<DateTime>(nullable: true),
                    InProgress = table.Column<bool>(nullable: true),
                    StudiesOnTime = table.Column<bool>(nullable: true),
                    DateInFuture = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
