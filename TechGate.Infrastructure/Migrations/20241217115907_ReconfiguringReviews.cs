using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class ReconfiguringReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62e9e69f-b639-464d-b8fb-294a2160f977", new DateTime(2024, 12, 17, 13, 59, 7, 356, DateTimeKind.Local).AddTicks(5888), "AQAAAAEAACcQAAAAEOL3vElppr+BE4GDA752TMF+3jNr/Xq9ZcAKJIKbsQxpSGmtBtym3OX8Xlec6rsUiQ==", "3bcaa8b6-14da-4f1b-a1e2-a64bd8d070a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7043e47-f067-4cb8-b4eb-34dda5dafcae", new DateTime(2024, 12, 17, 13, 59, 7, 355, DateTimeKind.Local).AddTicks(3509), "AQAAAAEAACcQAAAAEENY61CpytVn1MWN8aumFHYjagmrYakj6K/v23e0uvvGC74Pp9PorcuziE2XyuVAJQ==", "22985c66-02c3-4ad7-8f30-6297585901e0" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 13, 59, 7, 363, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 13, 29, 7, 363, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 13, 59, 7, 367, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 13, 59, 7, 367, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 17, 13, 59, 7, 369, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

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
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
