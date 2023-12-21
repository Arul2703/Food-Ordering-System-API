using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class otpupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPModels_SignupLogin_UserId",
                table: "OTPModels");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "OTPModels",
                newName: "FKUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OTPModels_UserId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserId",
                table: "OTPModels");

            migrationBuilder.RenameColumn(
                name: "FKUserId",
                table: "OTPModels",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_OTPModels_FKUserId",
                table: "OTPModels",
                newName: "IX_OTPModels_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPModels_SignupLogin_UserId",
                table: "OTPModels",
                column: "UserId",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
