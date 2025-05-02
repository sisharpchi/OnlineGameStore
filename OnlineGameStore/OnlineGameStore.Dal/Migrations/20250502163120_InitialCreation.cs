using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineGameStore.Dal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Genres_ParentGenreId",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameGenres",
                table: "GameGenres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Ganres");

            migrationBuilder.RenameTable(
                name: "GameGenres",
                newName: "GameGanres");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_ParentGenreId",
                table: "Ganres",
                newName: "IX_Ganres_ParentGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GameGenres_GenreId",
                table: "GameGanres",
                newName: "IX_GameGanres_GenreId");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Games",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ganres",
                table: "Ganres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameGanres",
                table: "GameGanres",
                columns: new[] { "GameId", "GenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_Games_Key",
                table: "Games",
                column: "Key");

            migrationBuilder.AddForeignKey(
                name: "FK_GameGanres_Games_GameId",
                table: "GameGanres",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGanres_Ganres_GenreId",
                table: "GameGanres",
                column: "GenreId",
                principalTable: "Ganres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ganres_Ganres_ParentGenreId",
                table: "Ganres",
                column: "ParentGenreId",
                principalTable: "Ganres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGanres_Games_GameId",
                table: "GameGanres");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGanres_Ganres_GenreId",
                table: "GameGanres");

            migrationBuilder.DropForeignKey(
                name: "FK_Ganres_Ganres_ParentGenreId",
                table: "Ganres");

            migrationBuilder.DropIndex(
                name: "IX_Games_Key",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ganres",
                table: "Ganres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameGanres",
                table: "GameGanres");

            migrationBuilder.RenameTable(
                name: "Ganres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "GameGanres",
                newName: "GameGenres");

            migrationBuilder.RenameIndex(
                name: "IX_Ganres_ParentGenreId",
                table: "Genres",
                newName: "IX_Genres_ParentGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GameGanres_GenreId",
                table: "GameGenres",
                newName: "IX_GameGenres_GenreId");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Games",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameGenres",
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Genres_ParentGenreId",
                table: "Genres",
                column: "ParentGenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
