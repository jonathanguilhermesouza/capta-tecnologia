using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaptaTecnologia.Data.Migrations
{
    public partial class Script_Initial_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "JOB");

            migrationBuilder.EnsureSchema(
                name: "SIS");

            migrationBuilder.EnsureSchema(
                name: "ACCOUNT");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "ACCOUNT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "SIS",
                columns: table => new
                {
                    Codigo = table.Column<string>(maxLength: 1, nullable: false),
                    Description = table.Column<string>(maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                schema: "JOB",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    GenderCodigo = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidate_Gender",
                        column: x => x.GenderCodigo,
                        principalSchema: "SIS",
                        principalTable: "Gender",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_GenderCodigo",
                schema: "JOB",
                table: "Candidate",
                column: "GenderCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "Candidate",
                schema: "JOB");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "SIS");
        }
    }
}
