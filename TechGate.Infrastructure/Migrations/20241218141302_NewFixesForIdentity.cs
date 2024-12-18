using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class NewFixesForIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "100 Tsarigradsko Shose Blvd, Sofia", "7a8522da-72a4-483f-a29a-0514c106bbbd", new DateTime(2024, 12, 18, 16, 2, 48, 895, DateTimeKind.Local).AddTicks(1322), new DateTime(1999, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "stoqn@gmail.com", false, false, null, "STOQN@GMAIL.COM", "STOQN@GMAIL.COM", "AQAAAAEAACcQAAAAEBbAvgln0XWcjobS4Htm7aq7SwIcgdavQNodJABn2q8/t0Tph3j43QgCb4+ROUmCtg==", null, false, "https://imgv3.fotor.com/images/blog-cover-image/10-profile-picture-ideas-to-make-you-stand-out.jpg", "e1bdd498-69cc-4fc5-aa3d-cdeb5c8fb856", false, "stoqn@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "5 Vitosha Boulevard, Sofia", "57783657-3690-4177-a695-a3d2909c936d", new DateTime(2024, 12, 18, 16, 2, 48, 894, DateTimeKind.Local).AddTicks(1885), new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "peter@gmail.com", false, false, null, "PETER@GMAIL.COM", "PETER@GMAIL.COM", "AQAAAAEAACcQAAAAEJl+a754AS/Gljmg8ROdUPkN8e0EBHwjFUvUyoVPEcSbDLNPTijqfVQOhSTQd1U+kA==", null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "4ba20600-caeb-4940-988b-09175f7734aa", false, "peter@gmail.com" }
                });

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
    }
}
