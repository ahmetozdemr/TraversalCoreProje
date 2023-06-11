using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_comment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DestinationID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DestinationID",
                table: "Comments",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Destinations_DestinationID",
                table: "Comments",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
