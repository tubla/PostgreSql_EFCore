using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSql.API.Migrations
{
    /// <inheritdoc />
    public partial class added_comment_to_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Teams",
                comment: "This is a model for F1 Teams to manage their Drivers");

            migrationBuilder.AlterTable(
                name: "F1Drivers",
                comment: "This is a model for F1 Drivers to manage their Team and Media");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Teams",
                oldComment: "This is a model for F1 Teams to manage their Drivers");

            migrationBuilder.AlterTable(
                name: "F1Drivers",
                oldComment: "This is a model for F1 Drivers to manage their Team and Media");
        }
    }
}
