using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PartComponentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productAssembledes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PartComponentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productAssembledes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartComponent",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartComponent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartComponent_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "dbo",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAndPart",
                columns: table => new
                {
                    PartComponentsId = table.Column<int>(type: "int", nullable: false),
                    ProductAssembliesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAndPart", x => new { x.PartComponentsId, x.ProductAssembliesId });
                    table.ForeignKey(
                        name: "FK_ProductAndPart_PartComponent_PartComponentsId",
                        column: x => x.PartComponentsId,
                        principalSchema: "dbo",
                        principalTable: "PartComponent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAndPart_productAssembledes_ProductAssembliesId",
                        column: x => x.ProductAssembliesId,
                        principalTable: "productAssembledes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartComponent_OrderId",
                schema: "dbo",
                table: "PartComponent",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAndPart_ProductAssembliesId",
                table: "ProductAndPart",
                column: "ProductAssembliesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAndPart");

            migrationBuilder.DropTable(
                name: "PartComponent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "productAssembledes");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "dbo");
        }
    }
}
