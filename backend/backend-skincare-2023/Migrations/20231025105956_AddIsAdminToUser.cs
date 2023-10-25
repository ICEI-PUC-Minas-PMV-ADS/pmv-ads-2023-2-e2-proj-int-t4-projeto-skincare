using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_skincare_2023.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAdminToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "perfil",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "perfil",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
