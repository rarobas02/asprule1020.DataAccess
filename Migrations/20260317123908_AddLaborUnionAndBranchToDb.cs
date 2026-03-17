using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddLaborUnionAndBranchToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Rule1020Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchUnits_Registers_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "Registers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LaborUnions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnionAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnionBLR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborUnions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaborUnions_Registers_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "Registers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchUnits_RegisterId",
                table: "BranchUnits",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_LaborUnions_RegisterId",
                table: "LaborUnions",
                column: "RegisterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchUnits");

            migrationBuilder.DropTable(
                name: "LaborUnions");
        }
    }
}
