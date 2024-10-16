using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilestoneLogistics.web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class resubmittingusersagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3459d879-9213-40e7-82e4-40e788361038",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e9ca60fb-68e8-4aa6-8f63-72953bc1d559", "cyphre187@yahoo.com", "CYPHRE187@YAHOO.COM", "AQAAAAIAAYagAAAAEDOr50RSKvAL0UwWXUejMmYZIis+ioDRktv5cw4unsc/RdvLjwub5a4pmWA4GWE6Bg==", "e0373972-5f59-417e-9bc9-617f69622c1a", "cyphre187" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3459d879-9213-40e7-82e4-40e788361038",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0790a1d5-afa0-47c1-a4ab-13f13b98d528", "superadmin@bloggy.com", "SUPERADMIN@BLOGGY.COM", "AQAAAAIAAYagAAAAENJSqNtKfOGmRqtPR0HuxQ5QvtS4nN2VUPSKqcWz/eLh1hJL7j+VxQdC0R37enurBg==", "a117ad13-2f7d-4296-ba34-66179a22192d", "superadmin@bloggy.com" });
        }
    }
}
