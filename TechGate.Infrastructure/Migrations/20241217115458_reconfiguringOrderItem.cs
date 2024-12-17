using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class reconfiguringOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdef15db-d736-4aee-88c8-3ce2bbc75430", new DateTime(2024, 12, 17, 13, 54, 58, 403, DateTimeKind.Local).AddTicks(4229), "AQAAAAEAACcQAAAAEAaEWq855mSTjoi53qu6vzH6Kooh2Lvrupr2fXY5hpw03YF+X8P48qNeuhBQUtl8XA==", "4d60fe49-cccf-4543-bfa7-027155185c67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c62f198e-b072-4b3d-b1bf-8fdf8ef0daac", new DateTime(2024, 12, 17, 13, 54, 58, 402, DateTimeKind.Local).AddTicks(3304), "AQAAAAEAACcQAAAAEMEI91sE5luVhgKcvQPAdPYC/ijQskGpBlu+D4otmLxI7pRzkJZWkQmLTa/m8c+e3Q==", "8ed3e05b-ac80-4152-adaf-51cdf1aadd60" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 13, 54, 58, 410, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 13, 24, 58, 410, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 13, 54, 58, 414, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 13, 54, 58, 414, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 17, 13, 54, 58, 416, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2fe9727-a27c-47e4-8958-e948054391d5", new DateTime(2024, 12, 3, 0, 12, 44, 325, DateTimeKind.Local).AddTicks(9059), "AQAAAAEAACcQAAAAEOctoNS0d/P650W4Mw4sk/2s8JrikxeL2/MlCmpmjKZ/kEGGYUGJJHKIqbeTh00SGQ==", "5e73adc6-c5da-44cc-a31a-f174acfd2e20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a3d45fc-56da-49cf-88db-ab987ca49609", new DateTime(2024, 12, 3, 0, 12, 44, 324, DateTimeKind.Local).AddTicks(9340), "AQAAAAEAACcQAAAAEGDNUP+80+Q6XETJq6Qut4ypQ2uP/X+7KtmWJlxBkM7lMtrnr2pNiY0Y48/aID8tIg==", "0b7d7900-7ffe-4550-aa74-5a041d9d1810" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 3, 0, 12, 44, 332, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 2, 23, 42, 44, 332, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 3, 0, 12, 44, 336, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 3, 0, 12, 44, 336, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 3, 0, 12, 44, 338, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
