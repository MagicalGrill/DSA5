using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DSA5.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anwendungsgebiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anwendungsgebiet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aspekt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspekt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Eigenschaft",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Kuerzel = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eigenschaft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Erfahrungsgrad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApGuthaben = table.Column<int>(type: "integer", nullable: false),
                    MaxEigenschaftWert = table.Column<int>(type: "integer", nullable: false),
                    MaxFertigkeitWert = table.Column<int>(type: "integer", nullable: false),
                    MaxKampftechnikWert = table.Column<int>(type: "integer", nullable: false),
                    MaxEigenschaftsPunkte = table.Column<int>(type: "integer", nullable: false),
                    MaxZauberLiturgien = table.Column<int>(type: "integer", nullable: false),
                    MaxFremdzauber = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erfahrungsgrad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kulturgruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kulturgruppe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merkmal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merkmal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxStufe = table.Column<int>(type: "integer", nullable: false),
                    ApProStufe = table.Column<int>(type: "integer", nullable: false),
                    MaxAnzahl = table.Column<int>(type: "integer", nullable: false),
                    IstSchlechteEigenschaft = table.Column<bool>(type: "boolean", nullable: false),
                    IstPersoenlichkeitsschwaeche = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nachteil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profession",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sonderfertigkeit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApKosten = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sonderfertigkeit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtAspekt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    GesamtStufe = table.Column<int>(type: "integer", nullable: false),
                    StufeProLiturgie = table.Column<int>(type: "integer", nullable: false),
                    AnzahlLiturgien = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtAspekt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtLeiteigenschaft",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MinWert = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtLeiteigenschaft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtMerkmal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    GesamtStufe = table.Column<int>(type: "integer", nullable: false),
                    StufeProZauber = table.Column<int>(type: "integer", nullable: false),
                    AnzahlZauber = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtMerkmal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtSpezies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeziesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtSpezies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitEmpfiehltSonderfertigkeit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmpfehlungId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitEmpfiehltSonderfertigkeit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spezies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Lebenspunkte = table.Column<int>(type: "integer", nullable: false),
                    Seelenkraft = table.Column<int>(type: "integer", nullable: false),
                    Zaehigkeit = table.Column<int>(type: "integer", nullable: false),
                    Geschwindigkeit = table.Column<int>(type: "integer", nullable: false),
                    ApKosten = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spezies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Steigerungsfaktor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApKostenMultiplikator = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steigerungsfaktor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TraditionEmpfiehltSonderfertigkeit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraditionEmpfiehltSonderfertigkeit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxStufe = table.Column<int>(type: "integer", nullable: false),
                    ApProStufe = table.Column<int>(type: "integer", nullable: false),
                    MaxAnzahl = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vorteil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBedingtAnwendungsgebiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnwendungsgebietId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBedingtAnwendungsgebiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBedingtAnwendungsgebiet_Anwendungsgebiet_An~",
                        column: x => x.AnwendungsgebietId,
                        principalTable: "Anwendungsgebiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Talentgruppe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf1Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf2Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf3Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talentgruppe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talentgruppe_Eigenschaft_Wurf1Id",
                        column: x => x.Wurf1Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talentgruppe_Eigenschaft_Wurf2Id",
                        column: x => x.Wurf2Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talentgruppe_Eigenschaft_Wurf3Id",
                        column: x => x.Wurf3Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tradition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApKosten = table.Column<int>(type: "integer", nullable: false),
                    LeiteigenschaftId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tradition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tradition_Eigenschaft_LeiteigenschaftId",
                        column: x => x.LeiteigenschaftId,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kultur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KulturgruppeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApWert = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kultur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kultur_Kulturgruppe_KulturgruppeId",
                        column: x => x.KulturgruppeId,
                        principalTable: "Kulturgruppe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NachteilBrauchtVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NachteilBrauchtVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NachteilBrauchtVorteil_Nachteil_NachteilId",
                        column: x => x.NachteilId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NachteilEmpfiehltNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmpfehlungId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NachteilEmpfiehltNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NachteilEmpfiehltNachteil_Nachteil_EmpfehlungId",
                        column: x => x.EmpfehlungId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBedingtNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBedingtNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBedingtNachteil_Nachteil_NachteilId",
                        column: x => x.NachteilId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionEmpfiehltNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfessionId = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionEmpfiehltNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltNachteil_Nachteil_NachteilId",
                        column: x => x.NachteilId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltNachteil_Profession_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Profession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionEmpfiehltSonderfertigkeit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfessionId = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionEmpfiehltSonderfertigkeit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltSonderfertigkeit_Profession_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Profession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltSonderfertigkeit_Sonderfertigkeit_Sonder~",
                        column: x => x.SonderfertigkeitId,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schrift",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schrift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schrift_Sonderfertigkeit_Id",
                        column: x => x.Id,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segnung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KarmalKosten = table.Column<int>(type: "integer", nullable: false),
                    AspektId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segnung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segnung_Sonderfertigkeit_Id",
                        column: x => x.Id,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtEigenschaft",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    EigenschaftId = table.Column<Guid>(type: "uuid", nullable: false),
                    Wert = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtEigenschaft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtEigenschaft_Eigenschaft_EigenschaftId",
                        column: x => x.EigenschaftId,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtEigenschaft_Sonderfertigkeit_Sonderf~",
                        column: x => x.SonderfertigkeitId,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtSonderfertigkeit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoraussetzungId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtSonderfertigkeit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtSonderfertigkeit_Sonderfertigkeit_Vo~",
                        column: x => x.VoraussetzungId,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtVorteil_Sonderfertigkeit_Sonderferti~",
                        column: x => x.SonderfertigkeitId,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sprache",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprache", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprache_Sonderfertigkeit_Id",
                        column: x => x.Id,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stabzauber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Volumen = table.Column<int>(type: "integer", nullable: false),
                    MerkmalId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stabzauber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stabzauber_Sonderfertigkeit_Id",
                        column: x => x.Id,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zaubertrick",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MerkmalId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaubertrick", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaubertrick_Sonderfertigkeit_Id",
                        column: x => x.Id,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeziesBedingtEigenschaften",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeziesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeziesBedingtEigenschaften", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeziesBedingtEigenschaften_Spezies_SpeziesId",
                        column: x => x.SpeziesId,
                        principalTable: "Spezies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeziesEmpfiehltNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeziesId = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeziesEmpfiehltNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltNachteil_Nachteil_NachteilId",
                        column: x => x.NachteilId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltNachteil_Spezies_SpeziesId",
                        column: x => x.SpeziesId,
                        principalTable: "Spezies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kampftechnik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SteigerungsfaktorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kampftechnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kampftechnik_Steigerungsfaktor_SteigerungsfaktorId",
                        column: x => x.SteigerungsfaktorId,
                        principalTable: "Steigerungsfaktor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionEmpfiehltVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfessionId = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionEmpfiehltVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltVorteil_Profession_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Profession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionEmpfiehltVorteil_Vorteil_VorteilId",
                        column: x => x.VorteilId,
                        principalTable: "Vorteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeziesEmpfiehltVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeziesId = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeziesEmpfiehltVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltVorteil_Spezies_SpeziesId",
                        column: x => x.SpeziesId,
                        principalTable: "Spezies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltVorteil_Vorteil_VorteilId",
                        column: x => x.VorteilId,
                        principalTable: "Vorteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VorteilBrauchtVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZielId = table.Column<Guid>(type: "uuid", nullable: false),
                    VoraussetzungId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VorteilBrauchtVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VorteilBrauchtVorteil_Vorteil_ZielId",
                        column: x => x.ZielId,
                        principalTable: "Vorteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VorteilEmpfiehltNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VorteilEmpfiehltNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VorteilEmpfiehltNachteil_Vorteil_VorteilId",
                        column: x => x.VorteilId,
                        principalTable: "Vorteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentgruppeId = table.Column<Guid>(type: "uuid", nullable: false),
                    SteigerungsfaktorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf1Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf2Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Wurf3Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BeeinflusstDurchBelastung = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talent_Eigenschaft_Wurf1Id",
                        column: x => x.Wurf1Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talent_Eigenschaft_Wurf2Id",
                        column: x => x.Wurf2Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talent_Eigenschaft_Wurf3Id",
                        column: x => x.Wurf3Id,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talent_Steigerungsfaktor_SteigerungsfaktorId",
                        column: x => x.SteigerungsfaktorId,
                        principalTable: "Steigerungsfaktor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Talent_Talentgruppe_TalentgruppeId",
                        column: x => x.TalentgruppeId,
                        principalTable: "Talentgruppe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KulturEmpfiehltNachteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KulturId = table.Column<Guid>(type: "uuid", nullable: false),
                    NachteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturEmpfiehltNachteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltNachteil_Kultur_KulturId",
                        column: x => x.KulturId,
                        principalTable: "Kultur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltNachteil_Nachteil_NachteilId",
                        column: x => x.NachteilId,
                        principalTable: "Nachteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KulturEmpfiehltVorteil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KulturId = table.Column<Guid>(type: "uuid", nullable: false),
                    VorteilId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturEmpfiehltVorteil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltVorteil_Kultur_KulturId",
                        column: x => x.KulturId,
                        principalTable: "Kultur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltVorteil_Vorteil_VorteilId",
                        column: x => x.VorteilId,
                        principalTable: "Vorteil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeziesEmpfiehltKultur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SpeziesId = table.Column<Guid>(type: "uuid", nullable: false),
                    KulturId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeziesEmpfiehltKultur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltKultur_Kultur_KulturId",
                        column: x => x.KulturId,
                        principalTable: "Kultur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeziesEmpfiehltKultur_Spezies_SpeziesId",
                        column: x => x.SpeziesId,
                        principalTable: "Spezies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeziesKannEigenschaftBedingen",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BedingteEigenschaftenId = table.Column<Guid>(type: "uuid", nullable: false),
                    EigenschaftId = table.Column<Guid>(type: "uuid", nullable: false),
                    Wert = table.Column<int>(type: "integer", nullable: false),
                    SpeziesBedingtEigenschaftenId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeziesKannEigenschaftBedingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeziesKannEigenschaftBedingen_Eigenschaft_EigenschaftId",
                        column: x => x.EigenschaftId,
                        principalTable: "Eigenschaft",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeziesKannEigenschaftBedingen_SpeziesBedingtEigenschaften_~",
                        column: x => x.SpeziesBedingtEigenschaftenId,
                        principalTable: "SpeziesBedingtEigenschaften",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KulturEmpfiehltTalent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KulturId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Empfehlungsstufe = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KulturEmpfiehltTalent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltTalent_Kultur_KulturId",
                        column: x => x.KulturId,
                        principalTable: "Kultur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KulturEmpfiehltTalent_Talent_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Liturgie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liturgie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liturgie_Talent_Id",
                        column: x => x.Id,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SonderfertigkeitBrauchtTalent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SonderfertigkeitId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Wert = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonderfertigkeitBrauchtTalent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtTalent_Sonderfertigkeit_Sonderfertig~",
                        column: x => x.SonderfertigkeitId,
                        principalTable: "Sonderfertigkeit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SonderfertigkeitBrauchtTalent_Talent_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zauber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiziertDurchSeelenkraft = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiziertDurchZaehigkeit = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zauber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zauber_Talent_Id",
                        column: x => x.Id,
                        principalTable: "Talent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LiturgieVerbreitung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZauberId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    LiturgieId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiturgieVerbreitung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LiturgieVerbreitung_Liturgie_LiturgieId",
                        column: x => x.LiturgieId,
                        principalTable: "Liturgie",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fluch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fluch_Zauber_Id",
                        column: x => x.Id,
                        principalTable: "Zauber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZauberVerbreitung",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZauberId = table.Column<Guid>(type: "uuid", nullable: false),
                    TraditionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZauberVerbreitung", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZauberVerbreitung_Zauber_ZauberId",
                        column: x => x.ZauberId,
                        principalTable: "Zauber",
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
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kampftechnik_SteigerungsfaktorId",
                table: "Kampftechnik",
                column: "SteigerungsfaktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Kultur_KulturgruppeId",
                table: "Kultur",
                column: "KulturgruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltNachteil_KulturId",
                table: "KulturEmpfiehltNachteil",
                column: "KulturId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltNachteil_NachteilId",
                table: "KulturEmpfiehltNachteil",
                column: "NachteilId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltTalent_KulturId",
                table: "KulturEmpfiehltTalent",
                column: "KulturId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltTalent_TalentId",
                table: "KulturEmpfiehltTalent",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltVorteil_KulturId",
                table: "KulturEmpfiehltVorteil",
                column: "KulturId");

            migrationBuilder.CreateIndex(
                name: "IX_KulturEmpfiehltVorteil_VorteilId",
                table: "KulturEmpfiehltVorteil",
                column: "VorteilId");

            migrationBuilder.CreateIndex(
                name: "IX_LiturgieVerbreitung_LiturgieId",
                table: "LiturgieVerbreitung",
                column: "LiturgieId");

            migrationBuilder.CreateIndex(
                name: "IX_NachteilBrauchtVorteil_NachteilId",
                table: "NachteilBrauchtVorteil",
                column: "NachteilId");

            migrationBuilder.CreateIndex(
                name: "IX_NachteilEmpfiehltNachteil_EmpfehlungId",
                table: "NachteilEmpfiehltNachteil",
                column: "EmpfehlungId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltNachteil_NachteilId",
                table: "ProfessionEmpfiehltNachteil",
                column: "NachteilId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltNachteil_ProfessionId",
                table: "ProfessionEmpfiehltNachteil",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltSonderfertigkeit_ProfessionId",
                table: "ProfessionEmpfiehltSonderfertigkeit",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltSonderfertigkeit_SonderfertigkeitId",
                table: "ProfessionEmpfiehltSonderfertigkeit",
                column: "SonderfertigkeitId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltVorteil_ProfessionId",
                table: "ProfessionEmpfiehltVorteil",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionEmpfiehltVorteil_VorteilId",
                table: "ProfessionEmpfiehltVorteil",
                column: "VorteilId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBedingtAnwendungsgebiet_AnwendungsgebietId",
                table: "SonderfertigkeitBedingtAnwendungsgebiet",
                column: "AnwendungsgebietId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBedingtNachteil_NachteilId",
                table: "SonderfertigkeitBedingtNachteil",
                column: "NachteilId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtEigenschaft_EigenschaftId",
                table: "SonderfertigkeitBrauchtEigenschaft",
                column: "EigenschaftId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtEigenschaft_SonderfertigkeitId",
                table: "SonderfertigkeitBrauchtEigenschaft",
                column: "SonderfertigkeitId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtSonderfertigkeit_VoraussetzungId",
                table: "SonderfertigkeitBrauchtSonderfertigkeit",
                column: "VoraussetzungId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtTalent_SonderfertigkeitId",
                table: "SonderfertigkeitBrauchtTalent",
                column: "SonderfertigkeitId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtTalent_TalentId",
                table: "SonderfertigkeitBrauchtTalent",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_SonderfertigkeitBrauchtVorteil_SonderfertigkeitId",
                table: "SonderfertigkeitBrauchtVorteil",
                column: "SonderfertigkeitId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesBedingtEigenschaften_SpeziesId",
                table: "SpeziesBedingtEigenschaften",
                column: "SpeziesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltKultur_KulturId",
                table: "SpeziesEmpfiehltKultur",
                column: "KulturId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltKultur_SpeziesId",
                table: "SpeziesEmpfiehltKultur",
                column: "SpeziesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltNachteil_NachteilId",
                table: "SpeziesEmpfiehltNachteil",
                column: "NachteilId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltNachteil_SpeziesId",
                table: "SpeziesEmpfiehltNachteil",
                column: "SpeziesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltVorteil_SpeziesId",
                table: "SpeziesEmpfiehltVorteil",
                column: "SpeziesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesEmpfiehltVorteil_VorteilId",
                table: "SpeziesEmpfiehltVorteil",
                column: "VorteilId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesKannEigenschaftBedingen_EigenschaftId",
                table: "SpeziesKannEigenschaftBedingen",
                column: "EigenschaftId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeziesKannEigenschaftBedingen_SpeziesBedingtEigenschaftenId",
                table: "SpeziesKannEigenschaftBedingen",
                column: "SpeziesBedingtEigenschaftenId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_SteigerungsfaktorId",
                table: "Talent",
                column: "SteigerungsfaktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_TalentgruppeId",
                table: "Talent",
                column: "TalentgruppeId");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_Wurf1Id",
                table: "Talent",
                column: "Wurf1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_Wurf2Id",
                table: "Talent",
                column: "Wurf2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Talent_Wurf3Id",
                table: "Talent",
                column: "Wurf3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Talentgruppe_Wurf1Id",
                table: "Talentgruppe",
                column: "Wurf1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Talentgruppe_Wurf2Id",
                table: "Talentgruppe",
                column: "Wurf2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Talentgruppe_Wurf3Id",
                table: "Talentgruppe",
                column: "Wurf3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tradition_LeiteigenschaftId",
                table: "Tradition",
                column: "LeiteigenschaftId");

            migrationBuilder.CreateIndex(
                name: "IX_VorteilBrauchtVorteil_ZielId",
                table: "VorteilBrauchtVorteil",
                column: "ZielId");

            migrationBuilder.CreateIndex(
                name: "IX_VorteilEmpfiehltNachteil_VorteilId",
                table: "VorteilEmpfiehltNachteil",
                column: "VorteilId");

            migrationBuilder.CreateIndex(
                name: "IX_ZauberVerbreitung_ZauberId",
                table: "ZauberVerbreitung",
                column: "ZauberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aspekt");

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
                name: "Erfahrungsgrad");

            migrationBuilder.DropTable(
                name: "Fluch");

            migrationBuilder.DropTable(
                name: "Kampftechnik");

            migrationBuilder.DropTable(
                name: "KulturEmpfiehltNachteil");

            migrationBuilder.DropTable(
                name: "KulturEmpfiehltTalent");

            migrationBuilder.DropTable(
                name: "KulturEmpfiehltVorteil");

            migrationBuilder.DropTable(
                name: "LiturgieVerbreitung");

            migrationBuilder.DropTable(
                name: "Merkmal");

            migrationBuilder.DropTable(
                name: "NachteilBrauchtVorteil");

            migrationBuilder.DropTable(
                name: "NachteilEmpfiehltNachteil");

            migrationBuilder.DropTable(
                name: "ProfessionEmpfiehltNachteil");

            migrationBuilder.DropTable(
                name: "ProfessionEmpfiehltSonderfertigkeit");

            migrationBuilder.DropTable(
                name: "ProfessionEmpfiehltVorteil");

            migrationBuilder.DropTable(
                name: "Schrift");

            migrationBuilder.DropTable(
                name: "Segnung");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBedingtAnwendungsgebiet");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBedingtNachteil");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtAspekt");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtEigenschaft");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtLeiteigenschaft");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtMerkmal");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtSonderfertigkeit");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtSpezies");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtTalent");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitBrauchtVorteil");

            migrationBuilder.DropTable(
                name: "SonderfertigkeitEmpfiehltSonderfertigkeit");

            migrationBuilder.DropTable(
                name: "SpeziesEmpfiehltKultur");

            migrationBuilder.DropTable(
                name: "SpeziesEmpfiehltNachteil");

            migrationBuilder.DropTable(
                name: "SpeziesEmpfiehltVorteil");

            migrationBuilder.DropTable(
                name: "SpeziesKannEigenschaftBedingen");

            migrationBuilder.DropTable(
                name: "Sprache");

            migrationBuilder.DropTable(
                name: "Stabzauber");

            migrationBuilder.DropTable(
                name: "Tradition");

            migrationBuilder.DropTable(
                name: "TraditionEmpfiehltSonderfertigkeit");

            migrationBuilder.DropTable(
                name: "VorteilBrauchtVorteil");

            migrationBuilder.DropTable(
                name: "VorteilEmpfiehltNachteil");

            migrationBuilder.DropTable(
                name: "Zaubertrick");

            migrationBuilder.DropTable(
                name: "ZauberVerbreitung");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Liturgie");

            migrationBuilder.DropTable(
                name: "Profession");

            migrationBuilder.DropTable(
                name: "Anwendungsgebiet");

            migrationBuilder.DropTable(
                name: "Kultur");

            migrationBuilder.DropTable(
                name: "Nachteil");

            migrationBuilder.DropTable(
                name: "SpeziesBedingtEigenschaften");

            migrationBuilder.DropTable(
                name: "Vorteil");

            migrationBuilder.DropTable(
                name: "Sonderfertigkeit");

            migrationBuilder.DropTable(
                name: "Zauber");

            migrationBuilder.DropTable(
                name: "Kulturgruppe");

            migrationBuilder.DropTable(
                name: "Spezies");

            migrationBuilder.DropTable(
                name: "Talent");

            migrationBuilder.DropTable(
                name: "Steigerungsfaktor");

            migrationBuilder.DropTable(
                name: "Talentgruppe");

            migrationBuilder.DropTable(
                name: "Eigenschaft");
        }
    }
}
