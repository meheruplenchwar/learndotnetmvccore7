using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj_Learn_ASP_Net_Core_MVC_7.Migrations
{
    /// <inheritdoc />
    public partial class addphonenofield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "tbl_person",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "tbl_person");
        }
    }
}
