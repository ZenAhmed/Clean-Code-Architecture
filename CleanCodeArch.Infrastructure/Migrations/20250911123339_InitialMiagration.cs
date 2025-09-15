using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanCodeArch.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMiagration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees_tb",
                columns: table => new
                {
                    employee_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    employee_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_tb", x => x.employee_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees_tb");
        }
    }
}
