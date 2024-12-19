using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class AddRolesToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "850c7c7e-eeec-4d94-9df2-82cbf534af92", new DateTime(2024, 12, 17, 15, 35, 6, 466, DateTimeKind.Local).AddTicks(7719), "AQAAAAEAACcQAAAAENst6LnTEPSv478LpF9lYluoKl9sj7H8/j1Ziz0MAZF184QfG4XtNulxuRya/nPepg==", "928be136-dec4-45a9-b17c-e5bf3962ed52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d497db11-0e07-4dea-bad6-19e944df2b13", new DateTime(2024, 12, 17, 15, 35, 6, 465, DateTimeKind.Local).AddTicks(8291), "AQAAAAEAACcQAAAAEAxLTFfXokDJOc/YsZq047ernlaimHMdsJSiXynfwInW/WfnayUsB7moe6oFoVyGeA==", "c318ddbf-e28c-4c02-99e1-be0a9bfa6579" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 15, 35, 6, 473, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 12, 17, 15, 5, 6, 473, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 15, 35, 6, 477, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 12, 17, 15, 35, 6, 477, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 17, 15, 35, 6, 479, DateTimeKind.Local).AddTicks(3473));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
