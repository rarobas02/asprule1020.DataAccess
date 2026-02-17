using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace asprule1020.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIdColumnInRegisters : Migration
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
                name: "Registers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rule1020Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstPhone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    EstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstLegalOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstLegalOrgOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstProvince = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstCityMun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstBrgy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstOwnerFirst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstOwnerMid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EstOwnerLast = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstCurrentCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstTotalAssets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstBusinessNature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstOtherBusNature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstMaleCount = table.Column<int>(type: "int", nullable: false),
                    EstFemaleCount = table.Column<int>(type: "int", nullable: false),
                    EstTotalEmployees = table.Column<int>(type: "int", nullable: false),
                    EstTechInfo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstTechInfo1Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstTechInfo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstTechInfo2Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstChemSubstance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstSECNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstSECDateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstBisPermitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstIsPeza = table.Column<bool>(type: "bit", nullable: false),
                    EstBisPermitDateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstBisPermitValidityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstOwnerValidIDNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstOwnerValidIDDateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstOwnerValidIDDateExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstOwnerValidIDDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstSECFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstBisPermitFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstOwnerValidIDFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstEvalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstEvalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstEvalRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstPoHeadName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstPoHeadEvalDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstPoHeadRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstEvalEmailSendStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstReopeningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstReasonForUpdate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstIsUpdating = table.Column<bool>(type: "bit", nullable: true),
                    EstIsEmailApprovedSent = table.Column<bool>(type: "bit", nullable: true),
                    EstEmailApprovedSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstIsEmailReapplicationSent = table.Column<bool>(type: "bit", nullable: true),
                    EstEmailReapplicationSentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstEvalAssinged = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstRegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Registers", x => x.Id);
                });

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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EstUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Registers_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "Registers",
                        principalColumn: "Id");
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
                name: "IX_AspNetUsers_RegisterId",
                table: "AspNetUsers",
                column: "RegisterId");

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
                name: "tbl_psgc_bgy");

            migrationBuilder.DropTable(
                name: "tbl_psgc_citymun");

            migrationBuilder.DropTable(
                name: "tbl_psgc_provdist");

            migrationBuilder.DropTable(
                name: "tbl_psgc_reg");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Registers");
        }
    }
}
