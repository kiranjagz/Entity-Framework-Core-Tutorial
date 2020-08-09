using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.Core.Tutorial.Migrations
{
    public partial class CreateKeyGenDB_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Randomizers",
                columns: table => new
                {
                    UniqueId = table.Column<Guid>(nullable: false),
                    KeyGen = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randomizers", x => x.UniqueId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randomizers");
        }
    }
}
