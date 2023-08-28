using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj_Learn_ASP_Net_Core_MVC_7.Migrations
{
    /// <inheritdoc />
    public partial class removedphoneno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tbl_person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tbl_person",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
