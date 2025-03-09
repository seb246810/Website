using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace course.Migrations
{
    /// <inheritdoc />
    public partial class updateddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "producti",
                table: "Product",
                newName: "ProductAlt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductAlt",
                table: "Product",
                newName: "producti");
        }
    }
}
