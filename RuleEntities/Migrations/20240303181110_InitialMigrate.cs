using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RuleEntities.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

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
                name: "range_weapon_special_rules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    weaponid = table.Column<long>(name: "weapon_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_range_weapon_special_rules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "range_weapons",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    range = table.Column<int>(type: "integer", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_range_weapons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "unit_special_rules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unitid = table.Column<long>(name: "unit_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unit_special_rules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "weapon_special_rules",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    weaponid = table.Column<long>(name: "weapon_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weapon_special_rules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEntityArmorSpecialRuleEntity",
                columns: table => new
                {
                    ArmorId = table.Column<long>(type: "bigint", nullable: false),
                    RulesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEntityArmorSpecialRuleEntity", x => new { x.ArmorId, x.RulesId });
                    table.ForeignKey(
                        name: "FK_ArmorEntityArmorSpecialRuleEntity_armor_special_rules_Rules~",
                        column: x => x.RulesId,
                        principalTable: "armor_special_rules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorEntityArmorSpecialRuleEntity_armors_ArmorId",
                        column: x => x.ArmorId,
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
                name: "RangeWeaponEntityRangeWeaponSpecialRule",
                columns: table => new
                {
                    RulesId = table.Column<long>(type: "bigint", nullable: false),
                    WeaponId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeWeaponEntityRangeWeaponSpecialRule", x => new { x.RulesId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_RangeWeaponEntityRangeWeaponSpecialRule_range_weapon_specia~",
                        column: x => x.RulesId,
                        principalTable: "range_weapon_special_rules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RangeWeaponEntityRangeWeaponSpecialRule_range_weapons_Weapo~",
                        column: x => x.WeaponId,
                        principalTable: "range_weapons",
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

            migrationBuilder.CreateTable(
                name: "RangeWeaponEntityUnitEntity",
                columns: table => new
                {
                    RangeWeaponsId = table.Column<long>(type: "bigint", nullable: false),
                    UnitsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeWeaponEntityUnitEntity", x => new { x.RangeWeaponsId, x.UnitsId });
                    table.ForeignKey(
                        name: "FK_RangeWeaponEntityUnitEntity_range_weapons_RangeWeaponsId",
                        column: x => x.RangeWeaponsId,
                        principalTable: "range_weapons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RangeWeaponEntityUnitEntity_units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitEntityUnitSpecialRuleEntity",
                columns: table => new
                {
                    RulesId = table.Column<long>(type: "bigint", nullable: false),
                    UnitId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitEntityUnitSpecialRuleEntity", x => new { x.RulesId, x.UnitId });
                    table.ForeignKey(
                        name: "FK_UnitEntityUnitSpecialRuleEntity_unit_special_rules_RulesId",
                        column: x => x.RulesId,
                        principalTable: "unit_special_rules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitEntityUnitSpecialRuleEntity_units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "units",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity",
                columns: table => new
                {
                    RulesId = table.Column<long>(type: "bigint", nullable: false),
                    WeaponId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity", x => new { x.RulesId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity_c~",
                        column: x => x.WeaponId,
                        principalTable: "close_combat_weapons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity_w~",
                        column: x => x.RulesId,
                        principalTable: "weapon_special_rules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEntityArmorSpecialRuleEntity_RulesId",
                table: "ArmorEntityArmorSpecialRuleEntity",
                column: "RulesId");

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
                name: "IX_CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity_W~",
                table: "CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_RangeWeaponEntityRangeWeaponSpecialRule_WeaponId",
                table: "RangeWeaponEntityRangeWeaponSpecialRule",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_RangeWeaponEntityUnitEntity_UnitsId",
                table: "RangeWeaponEntityUnitEntity",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitEntityUnitSpecialRuleEntity_UnitId",
                table: "UnitEntityUnitSpecialRuleEntity",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_units_band_id",
                table: "units",
                column: "band_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorEntityArmorSpecialRuleEntity");

            migrationBuilder.DropTable(
                name: "ArmorEntityUnitEntity");

            migrationBuilder.DropTable(
                name: "band_special_rules");

            migrationBuilder.DropTable(
                name: "CloseCombatWeaponEntityCloseCombatWeaponSpecialRuleEntity");

            migrationBuilder.DropTable(
                name: "RangeWeaponEntityRangeWeaponSpecialRule");

            migrationBuilder.DropTable(
                name: "RangeWeaponEntityUnitEntity");

            migrationBuilder.DropTable(
                name: "UnitEntityUnitSpecialRuleEntity");

            migrationBuilder.DropTable(
                name: "armor_special_rules");

            migrationBuilder.DropTable(
                name: "armors");

            migrationBuilder.DropTable(
                name: "close_combat_weapons");

            migrationBuilder.DropTable(
                name: "weapon_special_rules");

            migrationBuilder.DropTable(
                name: "range_weapon_special_rules");

            migrationBuilder.DropTable(
                name: "range_weapons");

            migrationBuilder.DropTable(
                name: "unit_special_rules");

            migrationBuilder.DropTable(
                name: "units");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
