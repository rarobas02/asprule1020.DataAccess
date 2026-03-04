using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEstFiledClosureDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EstFiledClosureDate",
                table: "Registers",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstFiledClosureDate",
                table: "Registers");
        }
    }
}
