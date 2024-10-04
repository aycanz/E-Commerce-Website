using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Tbl_Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_CategoryId",
                table: "Tbl_Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_Categories_CategoryId",
                table: "Tbl_Products",
                column: "CategoryId",
                principalTable: "Tbl_Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_Categories_CategoryId",
                table: "Tbl_Products");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Products_CategoryId",
                table: "Tbl_Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Tbl_Products");
        }
    }
}
