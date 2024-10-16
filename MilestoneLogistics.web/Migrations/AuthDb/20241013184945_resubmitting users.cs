using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilestoneLogistics.web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class resubmittingusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3459d879-9213-40e7-82e4-40e788361038",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0790a1d5-afa0-47c1-a4ab-13f13b98d528", "AQAAAAIAAYagAAAAENJSqNtKfOGmRqtPR0HuxQ5QvtS4nN2VUPSKqcWz/eLh1hJL7j+VxQdC0R37enurBg==", "a117ad13-2f7d-4296-ba34-66179a22192d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3459d879-9213-40e7-82e4-40e788361038",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f04ed03b-cdfc-4f07-be4b-8ce3808cd1bf", "AQAAAAIAAYagAAAAENlfn2kGni3cNVSh1WIootLzV9SloiDL369tGDGPG2v8HMwmAm0OOLAlRWnJ9Huh6w==", "cf743398-df94-4f97-9041-ec05c43ee645" });
        }
    }
}
