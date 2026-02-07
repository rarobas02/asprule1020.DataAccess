using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRegisterToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    transId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rule1020Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estPhone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estLegalOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estLegalOrgOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estCityMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estBrgy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estStreet = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    estOwnerFirst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estOwnerMid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    estOwnerLast = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estCurrentCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estTotalAssets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estBusinessNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estOtherBusNature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estMaleCount = table.Column<int>(type: "int", nullable: false),
                    estFemaleCount = table.Column<int>(type: "int", nullable: false),
                    estTotalEmployees = table.Column<int>(type: "int", nullable: false),
                    estTechInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo1Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estTechInfo2Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estChemSubstance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estSECNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estSECDateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estBisPermitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estBisPermitDateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estBisPermitValidityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estOwnerValidIDNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estOwnerValidIDDateIssued = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    estOwnerValidIDDateExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estOwnerValidIDDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    estSECFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estBisPermitFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estOwnerValidIDFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estEvalRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estPoHeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estPoHeadEvalDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estPoHeadRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estEvalEmailSendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estReopeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estReasonForUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estIsUpdating = table.Column<bool>(type: "bit", nullable: false),
                    estIsEmailApprovedSent = table.Column<bool>(type: "bit", nullable: false),
                    estEmailApprovedSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estIsEmailReapplicationSent = table.Column<bool>(type: "bit", nullable: false),
                    estEmailReapplicationSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estEvalAssinged = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.transId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Registers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
