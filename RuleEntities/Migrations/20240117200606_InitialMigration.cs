using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RuleEntities.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "armors",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RangeWeapons",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeWeapons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "armor_special_rules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    armorid = table.Column<long>(name: "armor_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_armor_special_rules", x => x.id);
                    table.ForeignKey(
                        name: "FK_armor_special_rules_armors_armor_id",
                        column: x => x.armorid,
                        principalTable: "armors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "band_special_rules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bandid = table.Column<long>(name: "band_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_band_special_rules", x => x.id);
                    table.ForeignKey(
                        name: "FK_band_special_rules_Bands_band_id",
                        column: x => x.bandid,
                        principalTable: "Bands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    maxunitcount = table.Column<int>(name: "max_unit_count", type: "integer", nullable: false),
                    unitcost = table.Column<int>(name: "unit_cost", type: "integer", nullable: false),
                    move = table.Column<int>(type: "integer", nullable: false),
                    weaponskill = table.Column<int>(name: "weapon_skill", type: "integer", nullable: false),
                    balisticskill = table.Column<int>(name: "balistic_skill", type: "integer", nullable: false),
                    strength = table.Column<int>(type: "integer", nullable: false),
                    toughest = table.Column<int>(type: "integer", nullable: false),
                    woonds = table.Column<int>(type: "integer", nullable: false),
                    initiative = table.Column<int>(type: "integer", nullable: false),
                    attacks = table.Column<int>(type: "integer", nullable: false),
                    leadership = table.Column<int>(type: "integer", nullable: false),
                    bandid = table.Column<long>(name: "band_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.id);
                    table.ForeignKey(
                        name: "FK_units_Bands_band_id",
                        column: x => x.bandid,
                        principalTable: "Bands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEntityUnitEntity",
                columns: table => new
                {
                    ArmorsId = table.Column<long>(type: "bigint", nullable: false),
                    UnitsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEntityUnitEntity", x => new { x.ArmorsId, x.UnitsId });
                    table.ForeignKey(
                        name: "FK_ArmorEntityUnitEntity_armors_ArmorsId",
                        column: x => x.ArmorsId,
                        principalTable: "armors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorEntityUnitEntity_units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "close_combat_weapons",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnitEntityId = table.Column<long>(type: "bigint", nullable: true),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_close_combat_weapons", x => x.id);
                    table.ForeignKey(
                        name: "FK_close_combat_weapons_units_UnitEntityId",
                        column: x => x.UnitEntityId,
                        principalTable: "units",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_armor_special_rules_armor_id",
                table: "armor_special_rules",
                column: "armor_id");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEntityUnitEntity_UnitsId",
                table: "ArmorEntityUnitEntity",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_band_special_rules_band_id",
                table: "band_special_rules",
                column: "band_id");

            migrationBuilder.CreateIndex(
                name: "IX_close_combat_weapons_UnitEntityId",
                table: "close_combat_weapons",
                column: "UnitEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_units_band_id",
                table: "units",
                column: "band_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "armor_special_rules");

            migrationBuilder.DropTable(
                name: "ArmorEntityUnitEntity");

            migrationBuilder.DropTable(
                name: "band_special_rules");

            migrationBuilder.DropTable(
                name: "close_combat_weapons");

            migrationBuilder.DropTable(
                name: "RangeWeapons");

            migrationBuilder.DropTable(
                name: "armors");

            migrationBuilder.DropTable(
                name: "units");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
