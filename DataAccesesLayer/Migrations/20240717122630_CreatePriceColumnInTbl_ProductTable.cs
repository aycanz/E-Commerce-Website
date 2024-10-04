using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesesLayer.Migrations
{
    /// <inheritdoc />
    public partial class CreatePriceColumnInTbl_ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Tbl_Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tbl_Products");
        }
    }
}
