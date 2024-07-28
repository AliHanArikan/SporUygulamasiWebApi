using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class first_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcerciseLevel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                });

            migrationBuilder.CreateTable(
                name: "ReadyTrainingInforms",
                columns: table => new
                {
                    ReadyTrainingInformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadyTrainingId = table.Column<int>(type: "int", nullable: false),
                    ReadyTrainingInformName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTime = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadyTrainingInforms", x => x.ReadyTrainingInformId);
                });

            migrationBuilder.CreateTable(
                name: "ReadyTrainings",
                columns: table => new
                {
                    ReadyTrainingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadyTrainingInformId = table.Column<int>(type: "int", nullable: false),
                    Exercise1 = table.Column<int>(type: "int", nullable: false),
                    Exercise2 = table.Column<int>(type: "int", nullable: false),
                    Exercise3 = table.Column<int>(type: "int", nullable: false),
                    Exercise4 = table.Column<int>(type: "int", nullable: false),
                    Exercise5 = table.Column<int>(type: "int", nullable: false),
                    Exercise6 = table.Column<int>(type: "int", nullable: false),
                    Exercise7 = table.Column<int>(type: "int", nullable: false),
                    Exercise8 = table.Column<int>(type: "int", nullable: false),
                    Exercise9 = table.Column<int>(type: "int", nullable: false),
                    Exercise10 = table.Column<int>(type: "int", nullable: false),
                    Exercise11 = table.Column<int>(type: "int", nullable: false),
                    Exercise12 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadyTrainings", x => x.ReadyTrainingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "ReadyTrainingInforms");

            migrationBuilder.DropTable(
                name: "ReadyTrainings");
        }
    }
}
