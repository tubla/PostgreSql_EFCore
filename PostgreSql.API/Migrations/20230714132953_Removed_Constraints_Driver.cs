using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSql.API.Migrations
{
    /// <inheritdoc />
    public partial class Removed_Constraints_Driver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_DriverMedia",
                table: "DriverMedias");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverMedias_Drivers_DriverId",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverMedias_Drivers_DriverId",
                table: "DriverMedias");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_DriverMedia",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
