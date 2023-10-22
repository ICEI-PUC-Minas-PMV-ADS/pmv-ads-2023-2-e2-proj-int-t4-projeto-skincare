using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_skincare_2023.Migrations
{
    /// <inheritdoc />
    public partial class UserTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "perfil",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "perfil",
                table: "Users");
        }
    }
}
