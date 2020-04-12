using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CEITeam.ECommerce.Data.Migrations
{
    public partial class AddRelationsFixForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fk_BrandId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_CategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Fk_ApplicationUserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fk_ApplicationUserId",
                table: "Brands",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_BrandId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fk_CustomerId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Fk_ProductId = table.Column<int>(nullable: false),
                    Fk_CustomerId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OrderedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => new { x.Fk_ProductId, x.Fk_CustomerId });
                    table.ForeignKey(
                        name: "FK_Order_Customers_Fk_CustomerId",
                        column: x => x.Fk_CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Products_Fk_ProductId",
                        column: x => x.Fk_ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                columns: table => new
                {
                    Fk_ProductId = table.Column<int>(nullable: false),
                    Fk_TagtId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => new { x.Fk_ProductId, x.Fk_TagtId });
                    table.ForeignKey(
                        name: "FK_ProductTag_Products_Fk_ProductId",
                        column: x => x.Fk_ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTag_Tags_Fk_TagtId",
                        column: x => x.Fk_TagtId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Fk_BrandId",
                table: "Products",
                column: "Fk_BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Fk_CategoryId",
                table: "Products",
                column: "Fk_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Fk_ApplicationUserId",
                table: "Customers",
                column: "Fk_ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Fk_ApplicationUserId",
                table: "Brands",
                column: "Fk_ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Fk_BrandId",
                table: "AspNetUsers",
                column: "Fk_BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Fk_CustomerId",
                table: "AspNetUsers",
                column: "Fk_CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Fk_CustomerId",
                table: "Order",
                column: "Fk_CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_Fk_TagtId",
                table: "ProductTag",
                column: "Fk_TagtId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Brands_Fk_BrandId",
                table: "AspNetUsers",
                column: "Fk_BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Customers_Fk_CustomerId",
                table: "AspNetUsers",
                column: "Fk_CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_AspNetUsers_Fk_ApplicationUserId",
                table: "Brands",
                column: "Fk_ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_Fk_ApplicationUserId",
                table: "Customers",
                column: "Fk_ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_Fk_BrandId",
                table: "Products",
                column: "Fk_BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Fk_CategoryId",
                table: "Products",
                column: "Fk_CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Brands_Fk_BrandId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customers_Fk_CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_AspNetUsers_Fk_ApplicationUserId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_Fk_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_Fk_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Fk_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropIndex(
                name: "IX_Products_Fk_BrandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Fk_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Fk_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Brands_Fk_ApplicationUserId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Fk_BrandId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Fk_CustomerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Fk_BrandId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Fk_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Fk_ApplicationUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Fk_ApplicationUserId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "Fk_BrandId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Fk_CustomerId",
                table: "AspNetUsers");
        }
    }
}
