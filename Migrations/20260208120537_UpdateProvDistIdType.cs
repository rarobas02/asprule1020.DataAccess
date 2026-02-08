using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProvDistIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_psgc_bgy",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    psgc_reg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_provdist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_citymun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city_municipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_submun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    submunicipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_bgy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barangay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geographic_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_psgc_bgy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_psgc_citymun",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    psgc_reg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_provdist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_citymun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city_municipality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geographic_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_psgc_citymun", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_psgc_provdist",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    psgc_reg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_provdist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_district = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geographic_level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_psgc_provdist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_psgc_reg",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    old_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    psgc_reg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geographic_level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_psgc_reg", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_psgc_bgy");

            migrationBuilder.DropTable(
                name: "tbl_psgc_citymun");

            migrationBuilder.DropTable(
                name: "tbl_psgc_provdist");

            migrationBuilder.DropTable(
                name: "tbl_psgc_reg");
        }
    }
}
