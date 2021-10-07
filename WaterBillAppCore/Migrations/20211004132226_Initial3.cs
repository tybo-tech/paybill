using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterBillAppCore.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QueryStatus",
                table: "queries",
                type: "nvarchar(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QueryStatus",
                table: "queries");
        }
    }
}
