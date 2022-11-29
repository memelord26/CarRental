using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1fa99059-578b-4ab4-9e4e-898cfee9f3f5", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "11848afd-5951-40b0-95ba-baeda70cfa3b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2e7c7d62-97b6-49a3-b27e-1b6c2fc5777b", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEAjaQYWbq3qBxmcdLWqbWEOZYpzWHhrqK3M0/Nb4vgRHBtn8kQREBFrW30p8VVa1cg==", null, false, "5d3d35e4-3d89-4ce7-a9f9-023aca0568fc", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 12, 22, 36, 295, DateTimeKind.Local).AddTicks(8138), new DateTime(2022, 11, 29, 12, 22, 36, 299, DateTimeKind.Local).AddTicks(3648), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 12, 22, 36, 299, DateTimeKind.Local).AddTicks(4832), new DateTime(2022, 11, 29, 12, 22, 36, 299, DateTimeKind.Local).AddTicks(4838), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 12, 22, 36, 300, DateTimeKind.Local).AddTicks(8243), new DateTime(2022, 11, 29, 12, 22, 36, 300, DateTimeKind.Local).AddTicks(8253), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 12, 22, 36, 300, DateTimeKind.Local).AddTicks(8257), new DateTime(2022, 11, 29, 12, 22, 36, 300, DateTimeKind.Local).AddTicks(8258), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2246), new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2252), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2255), new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2256), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2258), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2259), new DateTime(2022, 11, 29, 12, 22, 36, 301, DateTimeKind.Local).AddTicks(2260), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
