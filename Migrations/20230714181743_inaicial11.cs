using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoProductos.Migrations
{
    public partial class inaicial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ordenes_OrdenId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_OrdenId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "OrdenId",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "OrdenProducto",
                columns: table => new
                {
                    OrdenesId = table.Column<int>(type: "int", nullable: false),
                    ProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenProducto", x => new { x.OrdenesId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_OrdenProducto_Ordenes_OrdenesId",
                        column: x => x.OrdenesId,
                        principalTable: "Ordenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenProducto_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenProducto_ProductosId",
                table: "OrdenProducto",
                column: "ProductosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenProducto");

            migrationBuilder.AddColumn<int>(
                name: "OrdenId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_OrdenId",
                table: "Productos",
                column: "OrdenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ordenes_OrdenId",
                table: "Productos",
                column: "OrdenId",
                principalTable: "Ordenes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
