using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class MoreStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccountImage",
                table: "SYSUserProfile",
                type: "varchar(8000)",
                unicode: false,
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8000)",
                oldUnicode: false,
                oldMaxLength: 8000);

            migrationBuilder.CreateTable(
                name: "LOOKUPRole",
                columns: table => new
                {
                    LOOKUPRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RoleDescription = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    RowCreatedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowCreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    RowModifiedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUPRole", x => x.LOOKUPRoleID);
                });

            migrationBuilder.CreateTable(
                name: "SYSUserRole",
                columns: table => new
                {
                    SYSUserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SYSUserID = table.Column<int>(type: "int", nullable: false),
                    LOOKUPRoleID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RowCreatedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowCreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    RowModifiedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSUserRole", x => x.SYSUserRoleID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOOKUPRole");

            migrationBuilder.DropTable(
                name: "SYSUserRole");

            migrationBuilder.AlterColumn<string>(
                name: "AccountImage",
                table: "SYSUserProfile",
                type: "varchar(8000)",
                unicode: false,
                maxLength: 8000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(8000)",
                oldUnicode: false,
                oldMaxLength: 8000,
                oldNullable: true);
        }
    }
}
