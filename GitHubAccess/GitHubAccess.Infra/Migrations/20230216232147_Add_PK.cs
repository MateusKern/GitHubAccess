using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubAccess.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Add_PK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BdId",
                table: "GitHubRepositorio",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GitHubRepositorio",
                table: "GitHubRepositorio",
                column: "BdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GitHubRepositorio",
                table: "GitHubRepositorio");

            migrationBuilder.DropColumn(
                name: "BdId",
                table: "GitHubRepositorio");
        }
    }
}
