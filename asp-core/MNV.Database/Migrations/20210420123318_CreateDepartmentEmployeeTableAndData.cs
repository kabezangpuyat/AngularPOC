using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MNV.Database.Migrations
{
    public partial class CreateDepartmentEmployeeTableAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("01328c45-b6a7-4c98-b9d4-27c1a3d82fa4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d803f369-32f0-4024-8d82-e1f7e5f129d9"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 314, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 767, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("82fd93c1-521c-42c1-9572-e705b3ac24c2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("ccb25b82-191f-42d1-bdfd-5bdc6816a4a4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 311, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 762, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("adb4ecbe-5700-4e58-b106-a36f6591e836"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b3ca67c8-b437-4c77-b105-d48e5eeac5f2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 302, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 747, DateTimeKind.Unspecified).AddTicks(9833), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("e0a4ccac-a700-49a6-923c-6b24f5c695d1")),
                    CreatedByID = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedByID = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 288, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 8, 0, 0, 0))),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValue: new Guid("687297c4-a5bf-4eda-a664-0da68e1378dd")),
                    CreatedByID = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedByID = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 294, DateTimeKind.Unspecified).AddTicks(8966), new TimeSpan(0, 8, 0, 0, 0))),
                    DateModified = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Department",
                columns: new[] { "ID", "Active", "CreatedByID", "DateCreated", "DateModified", "Key", "ModifiedByID", "Name" },
                values: new object[,]
                {
                    { 1L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8435), new TimeSpan(0, 8, 0, 0, 0)), null, new Guid("2b7d30d0-8dc0-4343-9275-860e3959472e"), null, "IT - Corporate Applications" },
                    { 2L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8484), new TimeSpan(0, 8, 0, 0, 0)), null, new Guid("80b24d7b-8873-4e04-9b91-9fb70c07aacf"), null, "IT - Information Security" },
                    { 3L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(8486), new TimeSpan(0, 8, 0, 0, 0)), null, new Guid("a6f8787f-7701-4aa8-b877-4ed80eb1c4b3"), null, "IT - Information Access Management" }
                });

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
                columns: new[] { "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(273), new TimeSpan(0, 8, 0, 0, 0)), "rdiazy@email.com", "Romy", "Diaz", "B", "rdiazy@email.com" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "User",
                columns: new[] { "ID", "Active", "CreatedByID", "DateCreated", "DateModified", "Email", "FirstName", "Key", "LastName", "MiddleName", "ModifiedByID", "Password", "Username" },
                values: new object[] { 3L, true, 1L, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(277), new TimeSpan(0, 8, 0, 0, 0)), null, "pdiaz@email.com", "Pacquito", new Guid("a6f8787f-7701-4aa8-b877-4ed80eb1c4b3"), "Diaz", "B", null, "Jaemp2W0c4pSRQ8SMICEvg==", "pdiaz@email.com" });

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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Employee",
                columns: new[] { "ID", "Active", "CreatedByID", "DateCreated", "DateModified", "DepartmentID", "EmployeeID", "Key", "ModifiedByID", "PhotoFileName", "StartDate", "UserID" },
                values: new object[,]
                {
                    { 1L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4644), new TimeSpan(0, 8, 0, 0, 0)), null, 1L, "200117645", new Guid("2b7d30d0-8dc0-4343-9275-860e3959472e"), null, "anonymous.png", new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4132), new TimeSpan(0, 8, 0, 0, 0)), 1L },
                    { 2L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 8, 0, 0, 0)), null, 2L, "200117646", new Guid("80b24d7b-8873-4e04-9b91-9fb70c07aacf"), null, "anonymous.png", new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4705), new TimeSpan(0, 8, 0, 0, 0)), 2L },
                    { 3L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, 8, 0, 0, 0)), null, 3L, "200117647", new Guid("a6f8787f-7701-4aa8-b877-4ed80eb1c4b3"), null, "anonymous.png", new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 319, DateTimeKind.Unspecified).AddTicks(4715), new TimeSpan(0, 8, 0, 0, 0)), 3L }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "UserRole",
                columns: new[] { "ID", "Active", "CreatedByID", "DateCreated", "DateModified", "Key", "ModifiedByID", "RoleID", "UserID" },
                values: new object[] { 3L, true, null, new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 318, DateTimeKind.Unspecified).AddTicks(4684), new TimeSpan(0, 8, 0, 0, 0)), null, new Guid("a6f8787f-7701-4aa8-b877-4ed80eb1c4b3"), null, 2L, 3L });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentID",
                schema: "dbo",
                table: "Employee",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserID",
                schema: "dbo",
                table: "Employee",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "dbo");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d803f369-32f0-4024-8d82-e1f7e5f129d9"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("01328c45-b6a7-4c98-b9d4-27c1a3d82fa4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 767, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 314, DateTimeKind.Unspecified).AddTicks(3589), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("ccb25b82-191f-42d1-bdfd-5bdc6816a4a4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("82fd93c1-521c-42c1-9572-e705b3ac24c2"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 762, DateTimeKind.Unspecified).AddTicks(9159), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 311, DateTimeKind.Unspecified).AddTicks(769), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b3ca67c8-b437-4c77-b105-d48e5eeac5f2"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("adb4ecbe-5700-4e58-b106-a36f6591e836"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 747, DateTimeKind.Unspecified).AddTicks(9833), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 20, 33, 17, 302, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 770, DateTimeKind.Unspecified).AddTicks(674), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 770, DateTimeKind.Unspecified).AddTicks(1301), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Role",
                keyColumn: "ID",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 770, DateTimeKind.Unspecified).AddTicks(1321), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 772, DateTimeKind.Unspecified).AddTicks(2473), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "Email", "FirstName", "LastName", "MiddleName", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 772, DateTimeKind.Unspecified).AddTicks(2593), new TimeSpan(0, 8, 0, 0, 0)), "mcniel.viray@gmail.com", "McNiel", "Viray II", "N", "mcniel.viray@gmail.com" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 772, DateTimeKind.Unspecified).AddTicks(6969), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "UserRole",
                keyColumn: "ID",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTimeOffset(new DateTime(2021, 3, 25, 19, 26, 1, 772, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
