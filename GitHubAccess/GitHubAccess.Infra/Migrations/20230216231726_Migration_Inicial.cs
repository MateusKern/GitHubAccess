using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitHubAccess.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Migration_Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GitHubRepositorio",
                columns: table => new
                {
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HtmlUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CloneUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SshUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SvnUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MirrorUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    NodeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTemplate = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Homepage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Private = table.Column<bool>(type: "bit", nullable: false),
                    Fork = table.Column<bool>(type: "bit", nullable: false),
                    ForksCount = table.Column<int>(type: "int", nullable: false),
                    StargazersCount = table.Column<int>(type: "int", nullable: false),
                    WatchersCount = table.Column<int>(type: "int", nullable: false),
                    DefaultBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenIssuesCount = table.Column<int>(type: "int", nullable: false),
                    PushedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    HasIssues = table.Column<bool>(type: "bit", nullable: false),
                    HasWiki = table.Column<bool>(type: "bit", nullable: false),
                    HasDownloads = table.Column<bool>(type: "bit", nullable: false),
                    AllowRebaseMerge = table.Column<bool>(type: "bit", nullable: true),
                    AllowSquashMerge = table.Column<bool>(type: "bit", nullable: true),
                    AllowMergeCommit = table.Column<bool>(type: "bit", nullable: true),
                    HasPages = table.Column<bool>(type: "bit", nullable: false),
                    SubscribersCount = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    Archived = table.Column<bool>(type: "bit", nullable: false),
                    Topics = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteBranchOnMerge = table.Column<bool>(type: "bit", nullable: true),
                    AllowAutoMerge = table.Column<bool>(type: "bit", nullable: true),
                    AllowUpdateBranch = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GitHubRepositorio");
        }
    }
}
