using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UserEntities.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bands",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    currentpointcost = table.Column<int>(name: "current_point_cost", type: "integer", nullable: false),
                    maxpointcost = table.Column<int>(name: "max_point_cost", type: "integer", nullable: false),
                    ruleid = table.Column<string>(name: "rule_id", type: "text", nullable: false),
                    userid = table.Column<long>(name: "user_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bands", x => x.id);
                    table.ForeignKey(
                        name: "FK_bands_users_user_id",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "untis",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    modelruleid = table.Column<string>(name: "model_rule_id", type: "text", nullable: false),
                    closecombatweaponruleid = table.Column<string>(name: "close_combat_weapon_rule_id", type: "text", nullable: false),
                    rangeweaponruleid = table.Column<string>(name: "range_weapon_rule_id", type: "text", nullable: false),
                    armorsruleids = table.Column<List<string>>(name: "armors_rule_ids", type: "text[]", nullable: false),
                    bandid = table.Column<long>(name: "band_id", type: "bigint", nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_untis", x => x.id);
                    table.ForeignKey(
                        name: "FK_untis_bands_band_id",
                        column: x => x.bandid,
                        principalTable: "bands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bands_user_id",
                table: "bands",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_untis_band_id",
                table: "untis",
                column: "band_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "untis");

            migrationBuilder.DropTable(
                name: "bands");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
