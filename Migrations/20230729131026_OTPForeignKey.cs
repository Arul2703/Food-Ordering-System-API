using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class OTPForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserId",
                table: "OTPModels");

            migrationBuilder.RenameColumn(
                name: "FKUserId",
                table: "OTPModels",
                newName: "FKUserID");

            migrationBuilder.RenameIndex(
                name: "IX_OTPModels_FKUserId",
                table: "OTPModels",
                newName: "IX_OTPModels_FKUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserID",
                table: "OTPModels",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserID",
                table: "OTPModels");

            migrationBuilder.RenameColumn(
                name: "FKUserID",
                table: "OTPModels",
                newName: "FKUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OTPModels_FKUserID",
                table: "OTPModels",
                newName: "IX_OTPModels_FKUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserId",
                table: "OTPModels",
                column: "FKUserId",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
