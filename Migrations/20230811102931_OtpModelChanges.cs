using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class OtpModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_FoodItems_FkFoodItemId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_invoiceModel_FkInvoiceID",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "IsVerified",
                table: "otpModels",
                newName: "isVerified");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "otpModels",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FkInvoiceID",
                table: "orders",
                newName: "invoiceId");

            migrationBuilder.RenameColumn(
                name: "FkFoodItemId",
                table: "orders",
                newName: "foodItemId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_FkInvoiceID",
                table: "orders",
                newName: "IX_orders_invoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_FkFoodItemId",
                table: "orders",
                newName: "IX_orders_foodItemId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "invoiceModel",
                newName: "orderId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_FoodItems_foodItemId",
                table: "orders",
                column: "foodItemId",
                principalTable: "FoodItems",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_invoiceModel_invoiceId",
                table: "orders",
                column: "invoiceId",
                principalTable: "invoiceModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_FoodItems_foodItemId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_invoiceModel_invoiceId",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "isVerified",
                table: "otpModels",
                newName: "IsVerified");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "otpModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "invoiceId",
                table: "orders",
                newName: "FkInvoiceID");

            migrationBuilder.RenameColumn(
                name: "foodItemId",
                table: "orders",
                newName: "FkFoodItemId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_invoiceId",
                table: "orders",
                newName: "IX_orders_FkInvoiceID");

            migrationBuilder.RenameIndex(
                name: "IX_orders_foodItemId",
                table: "orders",
                newName: "IX_orders_FkFoodItemId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "invoiceModel",
                newName: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_FoodItems_FkFoodItemId",
                table: "orders",
                column: "FkFoodItemId",
                principalTable: "FoodItems",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_invoiceModel_FkInvoiceID",
                table: "orders",
                column: "FkInvoiceID",
                principalTable: "invoiceModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
