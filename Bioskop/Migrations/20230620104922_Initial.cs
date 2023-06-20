using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bioskop.Migrations
{
    public partial class Initial : Migration
    {
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
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Filmovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reziser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Glumci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zanrovi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trajanje = table.Column<int>(type: "int", nullable: false),
                    Distributer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZemljaPorekla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obrisan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoviProjekcije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviProjekcije", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Sedista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Broj = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sedista_Sale_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projekcije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    TipProjekcijeId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false),
                    VremePrikazivanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CenaKarte = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdministratorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Obrisana = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekcije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projekcije_AspNetUsers_AdminId",
                        column: x => x.AdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projekcije_Filmovi_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projekcije_Sale_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projekcije_TipoviProjekcije_TipProjekcijeId",
                        column: x => x.TipProjekcijeId,
                        principalTable: "TipoviProjekcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjekcijaId = table.Column<int>(type: "int", nullable: false),
                    SedisteId = table.Column<int>(type: "int", nullable: false),
                    VremeProdaje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KorisnikId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karte_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Karte_Projekcije_ProjekcijaId",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Karte_Sedista_SedisteId",
                        column: x => x.SedisteId,
                        principalTable: "Sedista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Deleted", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "RegistrationDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "89a481d0-09f7-42b6-b36e-a8b5e26b001a", 0, "171600dd-58d8-4a3b-b9ce-467fd3c230bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "admin@example.com", true, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEPeI6S1JXraOCI667RNTCB/nrMCQLJGiiC/co3esM092nD7r4Ahg3wQ5eYAvEjKEJw==", null, false, null, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "2592766c-3e3d-4fd2-91b9-29cfd8d634ca", false, "admin" },
                    { "74e4adb7-d426-4beb-9e57-5149f9834fc1", 0, "4a3e82dd-05ae-4ba1-ae2f-cae46dd6b83d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "korisnik1@test.com", true, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEEFxa01Gf2zBqmPAe/X1l/6R79ckTEIx75nX/oLBnjG+B8oBh3DYCmnihmgPHGWstA==", null, false, null, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "a8e8c8fe-e135-4429-97ee-96a2822bea67", false, "korisnik1" },
                    { "0c3a13e4-2cd9-4962-addd-9a2e00d1e8dc", 0, "ca505d91-760a-4222-b6b8-3898c8e992ab", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "korisnik2@test.com", true, null, null, false, null, null, null, "AQAAAAEAACcQAAAAEAae4p2BqMVPx+V5I5c9AsrIvpi+oueeb5TidXMCRLb8xa0Z63qh5zw4ECsNsq6XMg==", null, false, null, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "80ed72cb-82a8-437b-9d1e-22695c482df8", false, "korisnik2" }
                });

            migrationBuilder.InsertData(
                table: "Filmovi",
                columns: new[] { "Id", "Distributer", "Glumci", "GodinaProizvodnje", "Naziv", "Obrisan", "Opis", "Reziser", "Trajanje", "Zanrovi", "ZemljaPorekla" },
                values: new object[,]
                {
                    { 1, "Distr 1", "Glumci 1", 1985, "Film 1", false, "Opis 1", "Reziser 1", 120, "Zanrovi 1", "Zemlja 1" },
                    { 2, "Distr 2", "Glumci 2", 1984, "Film 2", false, "Opis 2", "Reziser 2", 110, "Zanrovi 2", "Zemlja 2" },
                    { 3, "Metro Goldwyn Mayer", "Mel Brooks, John Candy, Rick Moranis, Bill Pullman, Daphne Zuniga", 1987, "Spaceballs", false, "Opis", "Mel Brooks", 96, "Sci-Fi, Komedija, Avantura", "USA" },
                    { 4, "Distr 4", "Glumci 4", 1991, "Film 4", false, "Opis 4", "Reziser 4", 90, "Zanrovi 4", "Zemlja 4" },
                    { 5, "Distr 5", "Glumci 5", 2001, "Film 5", false, "Opis 5", "Reziser 5", 98, "Zanrovi 5", "Zemlja 5" }
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Mala sala" },
                    { 2, "Velika sala" },
                    { 3, "Ultimate sala" }
                });

            migrationBuilder.InsertData(
                table: "TipoviProjekcije",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "2D" },
                    { 2, "3D" },
                    { 3, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Sedista",
                columns: new[] { "Id", "Broj", "SalaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 25, 15, 2 },
                    { 26, 1, 3 },
                    { 27, 2, 3 },
                    { 28, 3, 3 },
                    { 29, 4, 3 },
                    { 30, 5, 3 },
                    { 31, 6, 3 },
                    { 32, 7, 3 },
                    { 33, 8, 3 },
                    { 34, 9, 3 },
                    { 35, 10, 3 },
                    { 36, 11, 3 },
                    { 37, 12, 3 },
                    { 38, 13, 3 },
                    { 39, 14, 3 },
                    { 40, 15, 3 },
                    { 41, 16, 3 },
                    { 42, 17, 3 },
                    { 43, 18, 3 },
                    { 24, 14, 2 },
                    { 44, 19, 3 },
                    { 23, 13, 2 },
                    { 21, 11, 2 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 7, 1 },
                    { 8, 8, 1 },
                    { 9, 9, 1 },
                    { 10, 10, 1 },
                    { 11, 1, 2 },
                    { 12, 2, 2 },
                    { 13, 3, 2 },
                    { 14, 4, 2 },
                    { 15, 5, 2 },
                    { 16, 6, 2 },
                    { 17, 7, 2 },
                    { 18, 8, 2 },
                    { 19, 9, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sedista",
                columns: new[] { "Id", "Broj", "SalaId" },
                values: new object[] { 20, 10, 2 });

            migrationBuilder.InsertData(
                table: "Sedista",
                columns: new[] { "Id", "Broj", "SalaId" },
                values: new object[] { 22, 12, 2 });

            migrationBuilder.InsertData(
                table: "Sedista",
                columns: new[] { "Id", "Broj", "SalaId" },
                values: new object[] { 45, 20, 3 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Karte_KorisnikId",
                table: "Karte",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_ProjekcijaId",
                table: "Karte",
                column: "ProjekcijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_SedisteId",
                table: "Karte",
                column: "SedisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_AdminId",
                table: "Projekcije",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_FilmId",
                table: "Projekcije",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_SalaId",
                table: "Projekcije",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projekcije_TipProjekcijeId",
                table: "Projekcije",
                column: "TipProjekcijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sedista_SalaId",
                table: "Sedista",
                column: "SalaId");
        }

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
                name: "Karte");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Projekcije");

            migrationBuilder.DropTable(
                name: "Sedista");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Filmovi");

            migrationBuilder.DropTable(
                name: "TipoviProjekcije");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
