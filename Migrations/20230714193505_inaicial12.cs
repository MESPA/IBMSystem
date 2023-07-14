using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoProductos.Migrations
{
    public partial class inaicial12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UnidadMedida",
                table: "Productos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnidadMedida",
                table: "Productos");
        }
    }
}
