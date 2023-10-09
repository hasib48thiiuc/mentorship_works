using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "itemName",
                table: "Solditems",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Solditems",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Sale_Quantity",
                table: "Solditems",
                newName: "StockOutType");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Solditems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "QuantityToChange",
                table: "Solditems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Solditems");

            migrationBuilder.DropColumn(
                name: "QuantityToChange",
                table: "Solditems");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Solditems",
                newName: "itemName");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Solditems",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "StockOutType",
                table: "Solditems",
                newName: "Sale_Quantity");
        }
    }
}
