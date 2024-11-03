using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Ibeg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewIndexId",
                table: "Reviews",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReviewIndex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NewReviewId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewIndex", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewIndex_Reviews_NewReviewId",
                        column: x => x.NewReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewIndexId",
                table: "Reviews",
                column: "ReviewIndexId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewIndex_NewReviewId",
                table: "ReviewIndex",
                column: "NewReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_ReviewIndex_ReviewIndexId",
                table: "Reviews",
                column: "ReviewIndexId",
                principalTable: "ReviewIndex",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_ReviewIndex_ReviewIndexId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ReviewIndex");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewIndexId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewIndexId",
                table: "Reviews");
        }
    }
}
