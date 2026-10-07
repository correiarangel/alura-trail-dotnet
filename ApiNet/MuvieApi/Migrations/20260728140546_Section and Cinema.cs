using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuvieApi.Migrations
{
    /// <inheritdoc />
    public partial class SectionandCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM pg_constraint
                        WHERE conname = 'FK_Sections_Cinemas_CinemaId'
                          AND conrelid = 'public.""Sections""'::regclass
                    ) THEN
                        ALTER TABLE ""Sections"" DROP CONSTRAINT ""FK_Sections_Cinemas_CinemaId"";
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF NOT EXISTS (
                        SELECT 1
                        FROM information_schema.columns
                        WHERE table_schema = 'public'
                          AND table_name = 'Sections'
                          AND column_name = 'CinemaId'
                    ) THEN
                        ALTER TABLE ""Sections"" ADD COLUMN ""CinemaId"" integer NULL;
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM information_schema.columns
                        WHERE table_schema = 'public'
                          AND table_name = 'Sections'
                          AND column_name = 'CinemaId'
                    ) THEN
                        ALTER TABLE ""Sections"" ALTER COLUMN ""CinemaId"" DROP NOT NULL;
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF NOT EXISTS (
                        SELECT 1
                        FROM pg_indexes
                        WHERE schemaname = 'public'
                          AND tablename = 'Sections'
                          AND indexname = 'IX_Sections_CinemaId'
                    ) THEN
                        CREATE INDEX ""IX_Sections_CinemaId"" ON ""Sections"" (""CinemaId"");
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF NOT EXISTS (
                        SELECT 1
                        FROM pg_constraint
                        WHERE conname = 'FK_Sections_Cinemas_CinemaId'
                          AND conrelid = 'public.""Sections""'::regclass
                    ) THEN
                        ALTER TABLE ""Sections""
                        ADD CONSTRAINT ""FK_Sections_Cinemas_CinemaId""
                        FOREIGN KEY (""CinemaId"")
                        REFERENCES ""Cinemas"" (""Id"");
                    END IF;
                END $$;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM pg_constraint
                        WHERE conname = 'FK_Sections_Cinemas_CinemaId'
                          AND conrelid = 'public.""Sections""'::regclass
                    ) THEN
                        ALTER TABLE ""Sections"" DROP CONSTRAINT ""FK_Sections_Cinemas_CinemaId"";
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF EXISTS (
                        SELECT 1
                        FROM information_schema.columns
                        WHERE table_schema = 'public'
                          AND table_name = 'Sections'
                          AND column_name = 'CinemaId'
                    ) THEN
                        ALTER TABLE ""Sections"" ALTER COLUMN ""CinemaId"" SET NOT NULL;
                    END IF;
                END $$;
            ");

            migrationBuilder.Sql(@"
                DO $$
                BEGIN
                    IF NOT EXISTS (
                        SELECT 1
                        FROM pg_constraint
                        WHERE conname = 'FK_Sections_Cinemas_CinemaId'
                          AND conrelid = 'public.""Sections""'::regclass
                    ) THEN
                        ALTER TABLE ""Sections""
                        ADD CONSTRAINT ""FK_Sections_Cinemas_CinemaId""
                        FOREIGN KEY (""CinemaId"")
                        REFERENCES ""Cinemas"" (""Id"")
                        ON DELETE CASCADE;
                    END IF;
                END $$;
            ");
        }
    }
}
