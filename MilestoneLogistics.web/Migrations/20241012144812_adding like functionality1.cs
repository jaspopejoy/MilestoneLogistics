using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilestoneLogistics.web.Migrations
{
    /// <inheritdoc />
    public partial class addinglikefunctionality1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostsLike_BlogPosts_BlogPostId",
                table: "BlogPostsLike");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostsLike",
                table: "BlogPostsLike");

            migrationBuilder.RenameTable(
                name: "BlogPostsLike",
                newName: "BlogPostLike");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostsLike_BlogPostId",
                table: "BlogPostLike",
                newName: "IX_BlogPostLike_BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostLike",
                table: "BlogPostLike",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostLike_BlogPosts_BlogPostId",
                table: "BlogPostLike",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPostLike_BlogPosts_BlogPostId",
                table: "BlogPostLike");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogPostLike",
                table: "BlogPostLike");

            migrationBuilder.RenameTable(
                name: "BlogPostLike",
                newName: "BlogPostsLike");

            migrationBuilder.RenameIndex(
                name: "IX_BlogPostLike_BlogPostId",
                table: "BlogPostsLike",
                newName: "IX_BlogPostsLike_BlogPostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogPostsLike",
                table: "BlogPostsLike",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPostsLike_BlogPosts_BlogPostId",
                table: "BlogPostsLike",
                column: "BlogPostId",
                principalTable: "BlogPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
