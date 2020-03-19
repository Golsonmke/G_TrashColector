using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProject.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78a3add5-0db9-4c14-93f3-78fa2dcf90d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8b2736f-8e44-4239-b4a9-11d051dd9c3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c995112e-0815-4ef8-baf9-fb3c4d3d89c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "406bb932-2b71-4403-aaf4-145d58097db9", "a4cb8f76-3c20-45a2-a33d-022cbb1f03f9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c50b0cba-fc54-440e-add6-e6dbaf2379f0", "a5c7cfec-b26b-4e5c-a033-1cbf40b19425", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d3ff81d-f609-474a-8aaa-04bb933a474f", "dc74f876-39cf-4d73-ad0e-449fd5b356ee", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "406bb932-2b71-4403-aaf4-145d58097db9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d3ff81d-f609-474a-8aaa-04bb933a474f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c50b0cba-fc54-440e-add6-e6dbaf2379f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8b2736f-8e44-4239-b4a9-11d051dd9c3f", "50318595-15fb-4899-9b78-26017af238fc", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78a3add5-0db9-4c14-93f3-78fa2dcf90d4", "f7c6d80f-1e18-40b6-90be-df16a01a7951", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c995112e-0815-4ef8-baf9-fb3c4d3d89c4", "c81f876b-028e-4581-b92c-4d5be70cf040", "Employee", "EMPLOYEE" });
        }
    }
}
