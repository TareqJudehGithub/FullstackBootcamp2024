using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourcesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[]
                    { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[]
                    {
                    Guid.NewGuid().ToString(),
                        "Admin",
                        "ADMIN",
                        Guid.NewGuid().ToString()
                     }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELET FROM [AspNetRoles]");
        }
    }
}
