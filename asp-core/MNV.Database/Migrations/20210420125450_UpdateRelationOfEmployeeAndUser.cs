using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MNV.Database.Migrations
{
    public partial class UpdateRelationOfEmployeeAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_UserID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d2c24240-608c-42a2-ab16-d2072e702480"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("01328c45-b6a7-4c98-b9d4-27c1a3d82fa4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 913, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 314, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("20b4b7d5-0c26-4914-a81d-1998ad793767"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("82fd93c1-521c-42c1-9572-e705b3ac24c2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 910, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 311, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("a9f27937-8b38-4951-b9f7-6d0beae07b25"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("adb4ecbe-5700-4e58-b106-a36f6591e836"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 905, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 302, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("c0847c04-5d3c-4341-8036-1ef80f252a6c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("687297c4-a5bf-4eda-a664-0da68e1378dd"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Employee",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 895, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 294, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Department",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("ec5bc007-d13f-4f46-ba90-14c484c95e7d"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e0a4ccac-a700-49a6-923c-6b24f5c695d1"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Department",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 889, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 288, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(111), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(165), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(168), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6637), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6132), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6697), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6708), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 918, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 915, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 915, DateTimeKind.Unspecified).AddTicks(1173), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 915, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(1673), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(1784), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(6349), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(6403), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 917, DateTimeKind.Unspecified).AddTicks(6405), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserID",
                schema: "dbo",
                table: "Employee",
                column: "UserID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_UserID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("01328c45-b6a7-4c98-b9d4-27c1a3d82fa4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d2c24240-608c-42a2-ab16-d2072e702480"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 314, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 913, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("82fd93c1-521c-42c1-9572-e705b3ac24c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("20b4b7d5-0c26-4914-a81d-1998ad793767"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 311, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 910, DateTimeKind.Unspecified).AddTicks(8070), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("adb4ecbe-5700-4e58-b106-a36f6591e836"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("a9f27937-8b38-4951-b9f7-6d0beae07b25"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 302, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 905, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("687297c4-a5bf-4eda-a664-0da68e1378dd"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("c0847c04-5d3c-4341-8036-1ef80f252a6c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Employee",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 294, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 895, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Department",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e0a4ccac-a700-49a6-923c-6b24f5c695d1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("ec5bc007-d13f-4f46-ba90-14c484c95e7d"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Department",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 288, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 54, 49, 889, DateTimeKind.Unspecified).AddTicks(7721), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8435), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Department",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Employee",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 8, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 316, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 316, DateTimeKind.Unspecified).AddTicks(650), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 316, DateTimeKind.Unspecified).AddTicks(671), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(4636), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(4681), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(4684), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserID",
                schema: "dbo",
                table: "Employee",
                column: "UserID");
        }
    }
}
