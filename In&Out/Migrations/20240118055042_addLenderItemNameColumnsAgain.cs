using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace In_Out.Migrations
{
    /// <inheritdoc />
    public partial class addLenderItemNameColumnsAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");
        }
    }
}
