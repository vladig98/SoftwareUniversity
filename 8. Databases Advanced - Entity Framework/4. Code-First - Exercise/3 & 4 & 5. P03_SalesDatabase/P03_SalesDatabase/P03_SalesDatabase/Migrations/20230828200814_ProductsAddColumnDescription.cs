using Microsoft.EntityFrameworkCore.Migrations;

namespace P03_SalesDatabase.Migrations
{
    public partial class ProductsAddColumnDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                maxLength: 250,
                nullable: true,
                defaultValue: "No description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
