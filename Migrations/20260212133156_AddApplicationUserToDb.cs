using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EstBisPermitDateIssued",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstBisPermitFile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstBisPermitNumber",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstBisPermitValidityDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstBrgy",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstBusinessNature",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstChemSubstance",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstCityMun",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstCurrentCap",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstEmailApprovedSentDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstEmailReapplicationSentDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstEvalAssinged",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstEvalDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstEvalEmailSendStatus",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstEvalName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstEvalRemarks",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstFemaleCount",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstIsEmailApprovedSent",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstIsEmailReapplicationSent",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EstIsUpdating",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstLegalOrg",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstLegalOrgOther",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstMaleCount",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOtherBusNature",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOwnerFirst",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOwnerLast",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOwnerMid",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstOwnerValidIDDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstOwnerValidIDDateExpire",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstOwnerValidIDDateIssued",
                table: "AspNetUsers",
                type: "datetime2",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOwnerValidIDFile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstOwnerValidIDNumber",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstPhone",
                table: "AspNetUsers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstPoHeadEvalDate",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstPoHeadName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstPoHeadRemarks",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstProvince",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstReasonForUpdate",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstRegion",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstRegistrationDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstReopeningDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstSECDateIssued",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstSECFile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstSECNumber",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstStatus",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstStreet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstTechInfo1",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstTechInfo1Other",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstTechInfo2",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstTechInfo2Other",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstTotalAssets",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstTotalEmployees",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstUsername",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegisterId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Register_EstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Register_EstProvince",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rule1020Id",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estEmail",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RegisterId",
                table: "AspNetUsers",
                column: "RegisterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_RegisterId",
                table: "AspNetUsers",
                column: "RegisterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_RegisterId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RegisterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBisPermitDateIssued",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBisPermitFile",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBisPermitNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBisPermitValidityDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBrgy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstBusinessNature",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstChemSubstance",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstCityMun",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstCurrentCap",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEmailApprovedSentDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEmailReapplicationSentDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEvalAssinged",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEvalDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEvalEmailSendStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEvalName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstEvalRemarks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstFemaleCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstIsEmailApprovedSent",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstIsEmailReapplicationSent",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstIsUpdating",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstLegalOrg",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstLegalOrgOther",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstMaleCount",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOtherBusNature",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerFirst",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerLast",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerMid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerValidIDDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerValidIDDateExpire",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerValidIDDateIssued",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerValidIDFile",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstOwnerValidIDNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstPoHeadEvalDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstPoHeadName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstPoHeadRemarks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstProvince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstReasonForUpdate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstRegion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstRegistrationDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstReopeningDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstSECDateIssued",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstSECFile",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstSECNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstStatus",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstStreet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTechInfo1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTechInfo1Other",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTechInfo2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTechInfo2Other",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTotalAssets",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstTotalEmployees",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstUsername",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisterId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Register_EstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Register_EstProvince",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Rule1020Id",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TransId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "estEmail",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    transId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    estBisPermitDateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estBisPermitFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estBisPermitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estBisPermitValidityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estBrgy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estBusinessNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estChemSubstance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estCityMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estCurrentCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estEmailApprovedSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estEmailReapplicationSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estEvalAssinged = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estEvalEmailSendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estFemaleCount = table.Column<int>(type: "int", nullable: false),
                    estIsEmailApprovedSent = table.Column<bool>(type: "bit", nullable: false),
                    estIsEmailReapplicationSent = table.Column<bool>(type: "bit", nullable: false),
                    estIsUpdating = table.Column<bool>(type: "bit", nullable: false),
                    estLegalOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estLegalOrgOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estMaleCount = table.Column<int>(type: "int", nullable: false),
                    estName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estOtherBusNature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estOwnerFirst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estOwnerLast = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estOwnerMid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    estOwnerValidIDDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estOwnerValidIDDateExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estOwnerValidIDDateIssued = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    estOwnerValidIDFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estOwnerValidIDNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estPhone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    estPoHeadEvalDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estPoHeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estPoHeadRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estReasonForUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estReopeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estSECDateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estSECFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estSECNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    estTechInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo1Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo2Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTotalAssets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estTotalEmployees = table.Column<int>(type: "int", nullable: false),
                    estType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rule1020Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.transId);
                });
        }
    }
}
