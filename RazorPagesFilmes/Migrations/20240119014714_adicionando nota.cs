using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesFilmes.Migrations
{
    public partial class adicionandonota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Filme");
        }
    }
}
