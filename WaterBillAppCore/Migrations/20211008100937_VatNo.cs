using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterBillAppCore.Migrations
{
    public partial class VatNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "bills",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Vat",
                table: "bills",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "Vat",
                table: "bills");
        }
    }
}
