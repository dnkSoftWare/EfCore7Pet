START TRANSACTION;

INSERT INTO "Actors" ("Id", "DayOfBirthday", "Fortune", "Name")
VALUES (2, DATE '1948-12-21', 15000.0, 'Samuel L. Jackson');
INSERT INTO "Actors" ("Id", "DayOfBirthday", "Fortune", "Name")
VALUES (3, DATE '1965-04-04', 18000.0, 'Robert Downey Jr.');

INSERT INTO "Movies" ("Id", "InTheaters", "ReleaseDate", "Title")
VALUES (3, FALSE, DATE '2021-12-13', 'Spider-Man: No Way Home');
INSERT INTO "Movies" ("Id", "InTheaters", "ReleaseDate", "Title")
VALUES (4, FALSE, DATE '2022-10-07', 'Spider-Man: Across the Spider-Verse (Part One)');
INSERT INTO "Movies" ("Id", "InTheaters", "ReleaseDate", "Title")
VALUES (5, FALSE, DATE '2019-04-22', 'Avengers Endgame');

INSERT INTO "GenreMovie" ("GenresId", "MoviesId")
VALUES (5, 3);
INSERT INTO "GenreMovie" ("GenresId", "MoviesId")
VALUES (5, 5);
INSERT INTO "GenreMovie" ("GenresId", "MoviesId")
VALUES (6, 4);

INSERT INTO "MovieActors" ("ActorId", "MovieId", "Character", "Order")
VALUES (2, 3, 'Nick Fury', 1);
INSERT INTO "MovieActors" ("ActorId", "MovieId", "Character", "Order")
VALUES (2, 5, 'Nick Fury', 2);
INSERT INTO "MovieActors" ("ActorId", "MovieId", "Character", "Order")
VALUES (3, 5, 'Iron Man', 1);

INSERT INTO "MovieComments" ("Id", "Content", "MovieId", "Recommend")
VALUES (4, 'Very good!!!', 5, TRUE);
INSERT INTO "MovieComments" ("Id", "Content", "MovieId", "Recommend")
VALUES (5, 'I love it!', 5, TRUE);
INSERT INTO "MovieComments" ("Id", "Content", "MovieId", "Recommend")
VALUES (6, 'They shouldn''t have done that', 3, FALSE);

SELECT setval(
    pg_get_serial_sequence('"Actors"', 'Id'),
    GREATEST(
        (SELECT MAX("Id") FROM "Actors") + 1,
        nextval(pg_get_serial_sequence('"Actors"', 'Id'))),
    false);
SELECT setval(
    pg_get_serial_sequence('"Movies"', 'Id'),
    GREATEST(
        (SELECT MAX("Id") FROM "Movies") + 1,
        nextval(pg_get_serial_sequence('"Movies"', 'Id'))),
    false);
SELECT setval(
    pg_get_serial_sequence('"MovieComments"', 'Id'),
    GREATEST(
        (SELECT MAX("Id") FROM "MovieComments") + 1,
        nextval(pg_get_serial_sequence('"MovieComments"', 'Id'))),
    false);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230822061219_TonsOfData', '7.0.10');

COMMIT;

