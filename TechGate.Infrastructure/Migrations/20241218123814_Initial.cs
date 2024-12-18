using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechGate.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AmounInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "identity",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "identity",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FinalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "identity",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "identity",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "identity",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "100 Tsarigradsko Shose Blvd, Sofia", "ce17e579-92ee-4629-bc11-2a6879fa4190", new DateTime(2024, 12, 18, 14, 38, 13, 947, DateTimeKind.Local).AddTicks(9771), new DateTime(1999, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "stoqn@gmail.com", false, false, null, "STOQN@GMAIL.COM", "STOQN@GMAIL.COM", "AQAAAAEAACcQAAAAEPYov603lffQ2VwabI1JGOwPC44VIS3POsioWTE5AsrUAiSb1F2LsMc3vhaj110SZA==", null, false, "https://imgv3.fotor.com/images/blog-cover-image/10-profile-picture-ideas-to-make-you-stand-out.jpg", "219088dc-8e9b-4557-bd53-41e0ea970241", false, "stoqn@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "5 Vitosha Boulevard, Sofia", "ff51ffe0-0b7b-4ebe-8d2b-bbdbdad4b616", new DateTime(2024, 12, 18, 14, 38, 13, 947, DateTimeKind.Local).AddTicks(279), new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter@gmail.com", false, false, null, "PETER@GMAIL.COM", "PETER@GMAIL.COM", "AQAAAAEAACcQAAAAEKeQa9F1+EDHM/CCx2jRSyLDDFlBbcAHIKxM+NAix6OSzg2C9uyou2jP3/GzvTCrfg==", null, false, "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_1280.png", "2e371878-4dce-41ed-a152-9c73ec6d9c13", false, "peter@gmail.com" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Headphones" },
                    { 2, "Earbuds" },
                    { 3, "Keyboards" },
                    { 4, "Mice" },
                    { 5, "Monitors" },
                    { 6, "Speakers" },
                    { 7, "Mouse Pads" },
                    { 8, "Gaming Chairs" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderStatus", "ShippingAddress", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 18, 14, 38, 13, 955, DateTimeKind.Local).AddTicks(1900), 0, "5 Vitosha Boulevard, Sofia", 69.99m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 2, new DateTime(2024, 12, 18, 14, 8, 13, 955, DateTimeKind.Local).AddTicks(1915), 5, "8 Alexander Nevsky Square, Sofia", 329.97m, "dea12856-c198-4129-b3f3-b893d8395082" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Products",
                columns: new[] { "Id", "AmounInStock", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 50, 4, "High-performance ergonomic gaming mouse with optical sensor.", "https://pcbuild.bg/assets/products/000/000/285/000000285414--geimarska-mishka-razer-basilisk-v3-pro-ergonomic-wireless-gaming-mouse-rz01-04620100-r3g1.jpg", "Razer DeathAdder V2 Mouse", 69.99m },
                    { 2, 30, 1, "Stereo gaming headset with superior sound quality and comfort.", "https://pcbuild.bg/assets/products/000/000/305/000000305273--geimarski-slushalki-razer-kraken-v3-x-wired-usb-gaming-headset-rz04-03750300-r3m1.jpg", "Razer Kraken Headphones", 99.99m },
                    { 3, 40, 3, "Mechanical gaming keyboard with RGB lighting and customizable keys.", "https://m.media-amazon.com/images/I/61Az2uOUbqL._AC_UF894,1000_QL80_.jpg", "Razer BlackWidow V3 Keyboard", 129.99m }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "OrderItems",
                columns: new[] { "Id", "FinalPrice", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 69.99m, 1, 1, 1 },
                    { 2, 199.98m, 2, 2, 2 },
                    { 3, 129.99m, 2, 3, 1 }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "OrderId", "PaymentDate", "PaymentMethod", "PaymentStatus", "UserId" },
                values: new object[,]
                {
                    { 1, 329.97m, 2, new DateTime(2024, 12, 18, 14, 38, 13, 959, DateTimeKind.Local).AddTicks(3665), 0, 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 2, 69.99m, 1, new DateTime(2024, 12, 18, 14, 38, 13, 959, DateTimeKind.Local).AddTicks(3667), 0, 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedAt", "ProductId", "Rating", "UserId" },
                values: new object[] { 1, "The mouse is great but razer loves installing malware", new DateTime(2024, 12, 18, 14, 38, 13, 961, DateTimeKind.Local).AddTicks(2684), 1, 4, "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "identity",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "identity",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "identity",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "identity",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "identity",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "identity",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                schema: "identity",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                schema: "identity",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                schema: "identity",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                schema: "identity",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                schema: "identity",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "identity",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                schema: "identity",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                schema: "identity",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Reviews",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "identity");
        }
    }
}
