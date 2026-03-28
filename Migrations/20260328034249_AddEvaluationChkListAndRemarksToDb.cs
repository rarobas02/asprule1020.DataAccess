using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEvaluationChkListAndRemarksToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EvaluationChecklists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    est_name_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_type_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_legalorg_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_adress_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_barangay_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_citymun_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_province_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_region_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_manag_first_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_manag_mid_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_manag_last_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_regdate_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bus_nature_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bnature_oth_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_cur_cap_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_total_asset_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_contact_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_tin_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_email_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_malenum_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_femalenum_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_totalemploy_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_techinfo1_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_techinfooth1_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_techinfo2_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_techinfooth2_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_chemsub_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_sec_number_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_sec_dateiss_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_sec_permit_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_peza_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bperm_number_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bperm_dateiss_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bperm_validity_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_bus_perm_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_valid_number_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_valid_dateiss_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_valid_validity_ck = table.Column<bool>(type: "bit", nullable: false),
                    est_termrep_ck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationChecklists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationChecklists_Registers_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "Registers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EvaluationRemarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegisterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    est_name_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_type_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_legalorg_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_adress_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_barangay_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_citymun_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_province_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_region_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_manag_first_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_manag_mid_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_manag_last_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_regdate_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bus_nature_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bnature_oth_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_cur_cap_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_total_asset_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_contact_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_tin_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_email_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_malenum_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_femalenum_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_totalemploy_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_techinfo1_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_techinfooth1_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_techinfo2_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_techinfooth2_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_chemsub_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_sec_number_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_sec_dateiss_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_sec_permit_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_peza_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bperm_number_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bperm_dateiss_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bperm_validity_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_bus_perm_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_valid_number_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_valid_dateiss_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_valid_validity_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    est_termrep_input = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationRemarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationRemarks_Registers_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "Registers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationChecklists_RegisterId",
                table: "EvaluationChecklists",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationRemarks_RegisterId",
                table: "EvaluationRemarks",
                column: "RegisterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EvaluationChecklists");

            migrationBuilder.DropTable(
                name: "EvaluationRemarks");
        }
    }
}
