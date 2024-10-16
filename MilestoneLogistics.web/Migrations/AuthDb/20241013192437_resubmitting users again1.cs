using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MilestoneLogistics.web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class resubmittingusersagain1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "3459d879-9213-40e7-82e4-40e788361038" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79fdfeef-908c-44f0-a949-c11bd6c07891", "3459d879-9213-40e7-82e4-40e788361038" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b67ed221-127e-4f1b-a013-74600d4aa65b", "3459d879-9213-40e7-82e4-40e788361038" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3459d879-9213-40e7-82e4-40e788361038");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b5e4fcc-b26c-4d92-a041-d6757ee3e719", 0, "43bde9ff-3ab3-4673-bae7-5ac6e4006ff7", "cyphre187@yahoo.com", false, false, null, "CYPHRE187@YAHOO.COM", null, "AQAAAAIAAYagAAAAEElq8IqbB5NlXVVtEZoYkgkuxOfIdslr0G5ZFxIBYQHs/v147VIn2v/ktcphyO/k7A==", null, false, "03198f57-ff39-4853-8953-feaca34e111b", false, "cyphre187" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" },
                    { "79fdfeef-908c-44f0-a949-c11bd6c07891", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" },
                    { "b67ed221-127e-4f1b-a013-74600d4aa65b", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79fdfeef-908c-44f0-a949-c11bd6c07891", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b67ed221-127e-4f1b-a013-74600d4aa65b", "0b5e4fcc-b26c-4d92-a041-d6757ee3e719" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b5e4fcc-b26c-4d92-a041-d6757ee3e719");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3459d879-9213-40e7-82e4-40e788361038", 0, "e9ca60fb-68e8-4aa6-8f63-72953bc1d559", "cyphre187@yahoo.com", false, false, null, "CYPHRE187@YAHOO.COM", null, "AQAAAAIAAYagAAAAEDOr50RSKvAL0UwWXUejMmYZIis+ioDRktv5cw4unsc/RdvLjwub5a4pmWA4GWE6Bg==", null, false, "e0373972-5f59-417e-9bc9-617f69622c1a", false, "cyphre187" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "3459d879-9213-40e7-82e4-40e788361038" },
                    { "79fdfeef-908c-44f0-a949-c11bd6c07891", "3459d879-9213-40e7-82e4-40e788361038" },
                    { "b67ed221-127e-4f1b-a013-74600d4aa65b", "3459d879-9213-40e7-82e4-40e788361038" }
                });
        }
    }
}
