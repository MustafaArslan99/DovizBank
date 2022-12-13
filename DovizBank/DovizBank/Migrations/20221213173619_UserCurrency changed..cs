using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DovizBank.Migrations
{
    /// <inheritdoc />
    public partial class UserCurrencychanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_UserCurrencies_UserCurrencyId",
                table: "Currencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserCurrencies_UserCurrencyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserCurrencyId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Currencies_UserCurrencyId",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "UserCurrencyId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserCurrencyId",
                table: "Currencies");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "UserCurrencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserCurrencies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "UserCurrencies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserCurrencies");

            migrationBuilder.AddColumn<int>(
                name: "UserCurrencyId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserCurrencyId",
                table: "Currencies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCurrencyId",
                table: "Users",
                column: "UserCurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_UserCurrencyId",
                table: "Currencies",
                column: "UserCurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_UserCurrencies_UserCurrencyId",
                table: "Currencies",
                column: "UserCurrencyId",
                principalTable: "UserCurrencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserCurrencies_UserCurrencyId",
                table: "Users",
                column: "UserCurrencyId",
                principalTable: "UserCurrencies",
                principalColumn: "Id");
        }
    }
}
