using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MilestoneLogistics.web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class newsuperuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2de4df79-52bf-40d3-9024-3a3fa9a9466e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79fdfeef-908c-44f0-a949-c11bd6c07891");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b67ed221-127e-4f1b-a013-74600d4aa65b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b5e4fcc-b26c-4d92-a041-d6757ee3e719");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15ccac94-b243-4dd4-a5c8-f6499a0602b8", "15ccac94-b243-4dd4-a5c8-f6499a0602b8", "SuperAdmin", "SuperAdmin" },
                    { "63550081-9b55-44bf-a13b-29cfc1c060eb", "63550081-9b55-44bf-a13b-29cfc1c060eb", "user", "user" },
                    { "b0414d8e-9cc3-4d37-8fab-d190009cc397", "b0414d8e-9cc3-4d37-8fab-d190009cc397", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce5332e7-6d2e-47d2-95c2-6a2254b76955", 0, "3898c746-d918-467e-bbf6-37b59702915f", "cyphre187@yahoo.com", false, false, null, "CYPHRE187@YAHOO.COM", null, "AQAAAAIAAYagAAAAELhCWQQuk2ym4JhUDs/V37XqLca0cef1g29SVUHKasBiEkFquaOSy2Yux0KFAuetiA==", null, false, "39141b1e-01e6-4030-ab7f-807fd11d0aa9", false, "cyphre187@yahoo.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "15ccac94-b243-4dd4-a5c8-f6499a0602b8", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" },
                    { "63550081-9b55-44bf-a13b-29cfc1c060eb", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" },
                    { "b0414d8e-9cc3-4d37-8fab-d190009cc397", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15ccac94-b243-4dd4-a5c8-f6499a0602b8", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63550081-9b55-44bf-a13b-29cfc1c060eb", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0414d8e-9cc3-4d37-8fab-d190009cc397", "ce5332e7-6d2e-47d2-95c2-6a2254b76955" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15ccac94-b243-4dd4-a5c8-f6499a0602b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63550081-9b55-44bf-a13b-29cfc1c060eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0414d8e-9cc3-4d37-8fab-d190009cc397");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce5332e7-6d2e-47d2-95c2-6a2254b76955");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "2de4df79-52bf-40d3-9024-3a3fa9a9466e", "Admin", "Admin" },
                    { "79fdfeef-908c-44f0-a949-c11bd6c07891", "79fdfeef-908c-44f0-a949-c11bd6c07891", "SuperAdmin", "SuperAdmin" },
                    { "b67ed221-127e-4f1b-a013-74600d4aa65b", "b67ed221-127e-4f1b-a013-74600d4aa65b", "user", "user" }
                });

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
    }
}
