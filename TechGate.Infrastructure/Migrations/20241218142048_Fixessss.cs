using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class Fixessss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3535fb1b-ad58-4d73-876d-dfd834277a27", new DateTime(2024, 12, 18, 16, 20, 48, 38, DateTimeKind.Local).AddTicks(8319), "AQAAAAEAACcQAAAAEJJfTAwA7ugqojvYgwc/zTFOtTyKdXq/C6xDEw0/IaJ26oucQQ3O6kTc/zV6Oq/ELw==", "0cb5c0ea-923d-471a-8698-e611ece92ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5151006f-6b23-433e-97a7-a93793061fb3", new DateTime(2024, 12, 18, 16, 20, 48, 37, DateTimeKind.Local).AddTicks(8543), "AQAAAAEAACcQAAAAEDRfobC3XDJOu/HFdGbcuPEewJXFvse+/XBXrBAOVfEaVUVt04Rs1nCGdqo8QQRD4A==", "b31c8970-55ae-434a-a5be-47a3f1fa2246" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 16, 20, 48, 45, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 15, 50, 48, 45, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 20, 48, 49, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 20, 48, 49, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 16, 20, 48, 51, DateTimeKind.Local).AddTicks(2177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ad631a1-43d1-48c7-890a-18fe4ef2ceb1", new DateTime(2024, 12, 18, 16, 13, 2, 437, DateTimeKind.Local).AddTicks(6277), "AQAAAAEAACcQAAAAEBb6VLfeoFLRoss6CLijX9zozDO1+ym2y5YLAv/uDS9ZSNwXL4kvJ1W4qxhxTJB84g==", "e1f2b9fb-d362-4ddc-b6da-247ccd436bef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec67b0f4-3c14-4909-9757-f7a1dd4810fb", new DateTime(2024, 12, 18, 16, 13, 2, 436, DateTimeKind.Local).AddTicks(6714), "AQAAAAEAACcQAAAAEJmgxZ/CYg3btfzJlfwxntASrXYv2fzJxjtNHfjR2/1FIbWQuWYKhKf6ch/wEvzhwg==", "2a25cbab-7217-4727-87b9-faea7ed361a4" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 16, 13, 2, 444, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 15, 43, 2, 444, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 13, 2, 448, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 13, 2, 448, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 16, 13, 2, 450, DateTimeKind.Local).AddTicks(4020));
        }
    }
}
