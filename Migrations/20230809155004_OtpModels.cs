using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class OtpModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserID",
                table: "OTPModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OTPModels",
                table: "OTPModels");

            migrationBuilder.RenameTable(
                name: "OTPModels",
                newName: "otpModels");

            migrationBuilder.RenameColumn(
                name: "OTPValue",
                table: "otpModels",
                newName: "otpValue");

            migrationBuilder.RenameIndex(
                name: "IX_OTPModels_FKUserID",
                table: "otpModels",
                newName: "IX_otpModels_FKUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_otpModels",
                table: "otpModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_otpModels_SignupLogin_FKUserID",
                table: "otpModels",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_otpModels_SignupLogin_FKUserID",
                table: "otpModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_otpModels",
                table: "otpModels");

            migrationBuilder.RenameTable(
                name: "otpModels",
                newName: "OTPModels");

            migrationBuilder.RenameColumn(
                name: "otpValue",
                table: "OTPModels",
                newName: "OTPValue");

            migrationBuilder.RenameIndex(
                name: "IX_otpModels_FKUserID",
                table: "OTPModels",
                newName: "IX_OTPModels_FKUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OTPModels",
                table: "OTPModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPModels_SignupLogin_FKUserID",
                table: "OTPModels",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
