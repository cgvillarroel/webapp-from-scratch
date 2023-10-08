using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.Migrations
{
    /// <inheritdoc />
    public partial class AccountImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SYSUser",
                columns: table => new
                {
                    SYSUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PasswordEncryptedText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowCreatedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowCreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    RowModifiedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSUser", x => x.SYSUserID);
                });

            migrationBuilder.CreateTable(
                name: "SYSUserProfile",
                columns: table => new
                {
                    SYSUserProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SYSUserID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "char(1)", nullable: false),
                    RowCreatedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowCreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    RowModifiedSYSUserID = table.Column<int>(type: "int", nullable: false),
                    RowModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    AccountImage = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSUserProfile", x => x.SYSUserProfileID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYSUser");

            migrationBuilder.DropTable(
                name: "SYSUserProfile");
        }
    }
}
