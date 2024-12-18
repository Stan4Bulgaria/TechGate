using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class FixingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8522da-72a4-483f-a29a-0514c106bbbd", new DateTime(2024, 12, 18, 16, 2, 48, 895, DateTimeKind.Local).AddTicks(1322), "AQAAAAEAACcQAAAAEBbAvgln0XWcjobS4Htm7aq7SwIcgdavQNodJABn2q8/t0Tph3j43QgCb4+ROUmCtg==", "e1bdd498-69cc-4fc5-aa3d-cdeb5c8fb856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57783657-3690-4177-a695-a3d2909c936d", new DateTime(2024, 12, 18, 16, 2, 48, 894, DateTimeKind.Local).AddTicks(1885), "AQAAAAEAACcQAAAAEJl+a754AS/Gljmg8ROdUPkN8e0EBHwjFUvUyoVPEcSbDLNPTijqfVQOhSTQd1U+kA==", "4ba20600-caeb-4940-988b-09175f7734aa" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 16, 2, 48, 901, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 18, 15, 32, 48, 901, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 2, 48, 905, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 18, 16, 2, 48, 905, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 16, 2, 48, 907, DateTimeKind.Local).AddTicks(8422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
