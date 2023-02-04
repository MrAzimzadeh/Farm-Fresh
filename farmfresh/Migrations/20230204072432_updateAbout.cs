using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace farmfresh.Migrations
{
    /// <inheritdoc />
    public partial class updateAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Abouts",
                newName: "PhotoUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "Abouts",
                newName: "Text");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
