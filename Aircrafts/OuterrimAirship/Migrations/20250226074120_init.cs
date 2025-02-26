using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OuterrimAirship.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrimeSyndicates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(120)", nullable: false),
                    Location = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimeSyndicates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mercenaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "varchar(45)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(45)", nullable: true),
                    BodySkills = table.Column<int>(type: "INTEGER", nullable: false),
                    CombatSkills = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercenaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpacecraftSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpecificationCode = table.Column<string>(type: "varchar(45)", nullable: false),
                    Structure = table.Column<int>(type: "INTEGER", nullable: false),
                    FuelTankCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    MinSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxAltitude = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpacecraftSpecifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MercenaryReputations",
                columns: table => new
                {
                    MercenaryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CrimeSyndicateId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReputationChange = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MercenaryReputations", x => new { x.CrimeSyndicateId, x.MercenaryId });
                    table.ForeignKey(
                        name: "FK_MercenaryReputations_CrimeSyndicates_CrimeSyndicateId",
                        column: x => x.CrimeSyndicateId,
                        principalTable: "CrimeSyndicates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MercenaryReputations_Mercenaries_MercenaryId",
                        column: x => x.MercenaryId,
                        principalTable: "Mercenaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spacecrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    Fuel = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Altitude = table.Column<int>(type: "INTEGER", nullable: false),
                    SpacecraftSpecificationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spacecrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spacecrafts_SpacecraftSpecifications_SpacecraftSpecificationId",
                        column: x => x.SpacecraftSpecificationId,
                        principalTable: "SpacecraftSpecifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compartments",
                columns: table => new
                {
                    CompartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpacecraftId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compartments", x => x.CompartmentId);
                    table.ForeignKey(
                        name: "FK_Compartments_Spacecrafts_SpacecraftId",
                        column: x => x.SpacecraftId,
                        principalTable: "Spacecrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    SpacecraftId = table.Column<int>(type: "INTEGER", nullable: false),
                    MercenaryId = table.Column<int>(type: "INTEGER", nullable: false),
                    JoinedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => new { x.MercenaryId, x.SpacecraftId });
                    table.ForeignKey(
                        name: "FK_Crews_Mercenaries_MercenaryId",
                        column: x => x.MercenaryId,
                        principalTable: "Mercenaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Crews_Spacecrafts_SpacecraftId",
                        column: x => x.SpacecraftId,
                        principalTable: "Spacecrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machineries",
                columns: table => new
                {
                    MachineryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Label = table.Column<string>(type: "varchar(45)", nullable: false),
                    Function = table.Column<string>(type: "varchar(200)", nullable: false),
                    CompartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machineries", x => x.MachineryId);
                    table.ForeignKey(
                        name: "FK_Machineries_Compartments_CompartmentId",
                        column: x => x.CompartmentId,
                        principalTable: "Compartments",
                        principalColumn: "CompartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compartments_SpacecraftId",
                table: "Compartments",
                column: "SpacecraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_SpacecraftId",
                table: "Crews",
                column: "SpacecraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_CompartmentId",
                table: "Machineries",
                column: "CompartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MercenaryReputations_MercenaryId",
                table: "MercenaryReputations",
                column: "MercenaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Spacecrafts_SpacecraftSpecificationId",
                table: "Spacecrafts",
                column: "SpacecraftSpecificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Machineries");

            migrationBuilder.DropTable(
                name: "MercenaryReputations");

            migrationBuilder.DropTable(
                name: "Compartments");

            migrationBuilder.DropTable(
                name: "CrimeSyndicates");

            migrationBuilder.DropTable(
                name: "Mercenaries");

            migrationBuilder.DropTable(
                name: "Spacecrafts");

            migrationBuilder.DropTable(
                name: "SpacecraftSpecifications");
        }
    }
}
