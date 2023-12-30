using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EldenRingAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttackDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Drops = table.Column<string[]>(type: "text[]", nullable: true),
                    HealthPoints = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageNegationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageNegationDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefenceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefenceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Effect = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerClasses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Stats = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequiredAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResistanceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResistanceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScalingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Scaling = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScalingDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sorceries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<double>(type: "double precision", nullable: false),
                    Slots = table.Column<int>(type: "integer", nullable: false),
                    Effects = table.Column<string>(type: "text", nullable: true),
                    RequiresId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorceries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sorceries_RequiredAttributes_RequiresId",
                        column: x => x.RequiresId,
                        principalTable: "RequiredAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    DmgNegationId = table.Column<int>(type: "integer", nullable: true),
                    ResistanceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Armors_DamageNegationDetails_DmgNegationId",
                        column: x => x.DmgNegationId,
                        principalTable: "DamageNegationDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Armors_ResistanceDetails_ResistanceId",
                        column: x => x.ResistanceId,
                        principalTable: "ResistanceDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shields",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    AttackId = table.Column<int>(type: "integer", nullable: true),
                    DefenceId = table.Column<int>(type: "integer", nullable: true),
                    RequiredAttributesId = table.Column<int>(type: "integer", nullable: true),
                    ScalesWithId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shields_AttackDetails_AttackId",
                        column: x => x.AttackId,
                        principalTable: "AttackDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shields_DefenceDetails_DefenceId",
                        column: x => x.DefenceId,
                        principalTable: "DefenceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shields_RequiredAttributes_RequiredAttributesId",
                        column: x => x.RequiredAttributesId,
                        principalTable: "RequiredAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Shields_ScalingDetails_ScalesWithId",
                        column: x => x.ScalesWithId,
                        principalTable: "ScalingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    AttackId = table.Column<int>(type: "integer", nullable: true),
                    DefenceId = table.Column<int>(type: "integer", nullable: true),
                    RequiredAttributesId = table.Column<int>(type: "integer", nullable: true),
                    ScalesWithId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_AttackDetails_AttackId",
                        column: x => x.AttackId,
                        principalTable: "AttackDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_DefenceDetails_DefenceId",
                        column: x => x.DefenceId,
                        principalTable: "DefenceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_RequiredAttributes_RequiredAttributesId",
                        column: x => x.RequiredAttributesId,
                        principalTable: "RequiredAttributes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Weapons_ScalingDetails_ScalesWithId",
                        column: x => x.ScalesWithId,
                        principalTable: "ScalingDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armors_DmgNegationId",
                table: "Armors",
                column: "DmgNegationId");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_ResistanceId",
                table: "Armors",
                column: "ResistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Shields_AttackId",
                table: "Shields",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_Shields_DefenceId",
                table: "Shields",
                column: "DefenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Shields_RequiredAttributesId",
                table: "Shields",
                column: "RequiredAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Shields_ScalesWithId",
                table: "Shields",
                column: "ScalesWithId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorceries_RequiresId",
                table: "Sorceries",
                column: "RequiresId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_AttackId",
                table: "Weapons",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_DefenceId",
                table: "Weapons",
                column: "DefenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_RequiredAttributesId",
                table: "Weapons",
                column: "RequiredAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_ScalesWithId",
                table: "Weapons",
                column: "ScalesWithId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "PlayerClasses");

            migrationBuilder.DropTable(
                name: "Shields");

            migrationBuilder.DropTable(
                name: "Sorceries");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "DamageNegationDetails");

            migrationBuilder.DropTable(
                name: "ResistanceDetails");

            migrationBuilder.DropTable(
                name: "AttackDetails");

            migrationBuilder.DropTable(
                name: "DefenceDetails");

            migrationBuilder.DropTable(
                name: "RequiredAttributes");

            migrationBuilder.DropTable(
                name: "ScalingDetails");
        }
    }
}
