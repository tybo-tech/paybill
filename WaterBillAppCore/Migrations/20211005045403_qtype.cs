using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterBillAppCore.Migrations
{
    public partial class qtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChargeRate",
                table: "querytypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SettingId",
                table: "querytypes",
                newName: "QueryTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "querytypes",
                newName: "ChargeRate");

            migrationBuilder.RenameColumn(
                name: "QueryTypeId",
                table: "querytypes",
                newName: "SettingId");
        }
    }
}
