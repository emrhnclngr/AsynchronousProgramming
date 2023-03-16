using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsynchronousProgramming.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Name", "Slug", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 16, 3, 49, 22, 749, DateTimeKind.Local).AddTicks(8146), null, "Elektronik", "elektronik", 1, null },
                    { 2, new DateTime(2023, 3, 16, 3, 49, 22, 752, DateTimeKind.Local).AddTicks(1729), null, "Beyaz Eşya", "beyaz eşya", 1, null },
                    { 3, new DateTime(2023, 3, 16, 3, 49, 22, 752, DateTimeKind.Local).AddTicks(1747), null, "Mobilya", "mobilya", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "CreateDate", "DeleteDate", "Slug", "Status", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Favoriler", new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(6578), null, "favoriler", 1, "Favoriler", null },
                    { 2, "Sepet", new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(7284), null, "sepet", 1, "Sepet", null },
                    { 3, "Home", new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(7289), null, "home", 1, "Home", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "Image", "Name", "Slug", "Status", "UnitPrice", "UpdateDate" },
                values: new object[] { 1, 1, new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(3312), null, "Monster-Laptop", null, "Laptop", "laptop", 1, 0m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "Image", "Name", "Slug", "Status", "UnitPrice", "UpdateDate" },
                values: new object[] { 2, 2, new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(4278), null, "Buzdolabı", null, "Buzdolabı", "buzdolabı", 1, 0m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "Image", "Name", "Slug", "Status", "UnitPrice", "UpdateDate" },
                values: new object[] { 3, 3, new DateTime(2023, 3, 16, 3, 49, 22, 753, DateTimeKind.Local).AddTicks(4284), null, "Yemek masası", null, "Masa", "masa", 1, 0m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
