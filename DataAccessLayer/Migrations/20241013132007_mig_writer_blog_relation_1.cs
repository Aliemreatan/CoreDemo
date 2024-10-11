using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_writer_blog_relation_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Contacts_ContactID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_ContactID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "Blogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_ContactID",
                table: "Blogs",
                column: "ContactID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Contacts_ContactID",
                table: "Blogs",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID");
        }
    }
}
