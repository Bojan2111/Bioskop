--Connect to MSSQLLocalDB
use Bioskop;
select * from AspNetRoleClaims;
select * from AspNetUserClaims;
select * from AspNetUserLogins;
select * from AspNetUserRoles;
select * from AspNetUserTokens;
select * from AspNetUsers;
select * from Karte;
select * from AspNetRoles;
select * from Projekcije;
select * from Sedista;
select * from Filmovi;
select * from TipoviProjekcije;
select * from Sale;
--insert into [Projekcije] ([FilmId], [TipProjekcijeId], [SalaId], [VremePrikazivanja], [CenaKarte], [AdministratorId], [Obrisana]) values
--(2, 1, 2, '2023-6-13T11:30:00.0000000', 350.00, N'89a481d0-09f7-42b6-b36e-a8b5e26b001a', 0),
--(1, 2, 1, '2023-6-7T10:45:00.0000000', 400.00, N'89a481d0-09f7-42b6-b36e-a8b5e26b001a', 0),
--(5, 3, 3, '2023-6-14T13:15:00.0000000', 550.00, N'89a481d0-09f7-42b6-b36e-a8b5e26b001a', 0),
--(2, 2, 1, '2023-6-14T16:30:00.0000000', 400.00, N'89a481d0-09f7-42b6-b36e-a8b5e26b001a', 0),
--(2, 3, 1, '2023-6-14T18:45:00.0000000', 450.00, N'89a481d0-09f7-42b6-b36e-a8b5e26b001a', 0);

--INSERT INTO [Karte] ( [ProjekcijaId], [SedisteId], [VremeProdaje], [KorisnikId] ) VALUES
--(7, 11, '2023-05-26T12:35:13.0000000', N'74e4adb7-d426-4beb-9e57-5149f9834fc1'),
--(7, 21, '2023-05-27T19:15:43.0000000', N'0c3a13e4-2cd9-4962-addd-9a2e00d1e8dc'),
--(8, 8, '2023-05-27T18:45:33.0000000', N'0c3a13e4-2cd9-4962-addd-9a2e00d1e8dc'),
--(9, 33, '2023-05-28T11:24:31.0000000', N'0c3a13e4-2cd9-4962-addd-9a2e00d1e8dc'),
--(10, 2, '2023-05-27T19:11:56.0000000', N'74e4adb7-d426-4beb-9e57-5149f9834fc1'),
--(10, 3, '2023-05-28T10:14:53.0000000', N'74e4adb7-d426-4beb-9e57-5149f9834fc1'),
--(11, 1, '2023-05-26T09:38:00.0000000', N'0c3a13e4-2cd9-4962-addd-9a2e00d1e8dc');

--insert into [AspNetRoleClaims] ([RoleId], [ClaimType], [ClaimValue]) values
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanViewUsers'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanViewFilmovi'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanViewProjekcije'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanViewKarte'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanCreateProjekcija'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanCreateFilm'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanEditUser'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanEditFilm'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanDeleteUser'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanDeleteFilm'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanDeleteProjekcija'),
--( N'fa6e2ac6-dd1b-4348-8a9f-c1d05cff5aa8', 'Permission', 'CanDeleteKarta'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanViewFilmovi'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanViewProjekcije'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanViewOwnKarte'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanViewSelf'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanCreateKarta'),
--( N'2be8c6c0-c1b7-4692-986d-bdce6b68485a', 'Permission', 'CanEditSelf');
