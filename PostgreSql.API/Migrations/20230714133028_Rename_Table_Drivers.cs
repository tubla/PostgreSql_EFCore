using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSql.API.Migrations
{
    /// <inheritdoc />
    public partial class Rename_Table_Drivers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverMedias_Drivers_DriverId",
                table: "DriverMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Drivers",
                newName: "F1Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_TeamId",
                table: "F1Drivers",
                newName: "IX_F1Drivers_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_F1Drivers",
                table: "F1Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverMedias_F1Drivers_DriverId",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "F1Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverMedias_F1Drivers_DriverId",
                table: "DriverMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_F1Drivers",
                table: "F1Drivers");

            migrationBuilder.RenameTable(
                name: "F1Drivers",
                newName: "Drivers");

            migrationBuilder.RenameIndex(
                name: "IX_F1Drivers_TeamId",
                table: "Drivers",
                newName: "IX_Drivers_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                table: "Drivers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverMedias_Drivers_DriverId",
                table: "DriverMedias",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
