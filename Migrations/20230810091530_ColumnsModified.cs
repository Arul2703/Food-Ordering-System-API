using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderingSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class ColumnsModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_FoodCategories_FoodCategoryName",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_invoiceModel_SignupLogin_FKUserID",
                table: "invoiceModel");

            migrationBuilder.DropForeignKey(
                name: "FK_otpModels_SignupLogin_FKUserID",
                table: "otpModels");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_SignupLogin_FKUserID",
                table: "UserProfile");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "UserProfile",
                newName: "profilePicture");

            migrationBuilder.RenameColumn(
                name: "Pincode",
                table: "UserProfile",
                newName: "pincode");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserProfile",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "UserProfile",
                newName: "mobileNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UserProfile",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "UserProfile",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "UserProfile",
                newName: "profileId");

            migrationBuilder.RenameColumn(
                name: "FKUserID",
                table: "UserProfile",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfile_FKUserID",
                table: "UserProfile",
                newName: "IX_UserProfile_userId");

            migrationBuilder.RenameColumn(
                name: "RememberMe",
                table: "SignupLogin",
                newName: "rememberMe");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "SignupLogin",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SignupLogin",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "SignupLogin",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "ConfirmPassword",
                table: "SignupLogin",
                newName: "confirmPassword");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "SignupLogin",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "otpModels",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "FKUserID",
                table: "otpModels",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_otpModels_FKUserID",
                table: "otpModels",
                newName: "IX_otpModels_userId");

            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "orders",
                newName: "orderStatus");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "orders",
                newName: "unitPrice");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "orders",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "orders",
                newName: "orderDate");

            migrationBuilder.RenameColumn(
                name: "Order_Bill",
                table: "orders",
                newName: "orderBill");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "invoiceModel",
                newName: "transactionId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "invoiceModel",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FKUserID",
                table: "invoiceModel",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "DateInvoice",
                table: "invoiceModel",
                newName: "dateOfInvoice");

            migrationBuilder.RenameIndex(
                name: "IX_invoiceModel_FKUserID",
                table: "invoiceModel",
                newName: "IX_invoiceModel_userId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "FoodItems",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodItems",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsVegan",
                table: "FoodItems",
                newName: "isVegan");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "FoodItems",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryName",
                table: "FoodItems",
                newName: "FoodCategoryname");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FoodItems",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "FoodItems",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Calories",
                table: "FoodItems",
                newName: "calories");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FoodItems",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItems_FoodCategoryName",
                table: "FoodItems",
                newName: "IX_FoodItems_FoodCategoryname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FoodCategories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "CheckoutDetails",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "PinCode",
                table: "CheckoutDetails",
                newName: "pincode");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CheckoutDetails",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "CheckoutDetails",
                newName: "mobileNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "CheckoutDetails",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "CheckoutDetails",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CheckoutDetails",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_FoodCategories_FoodCategoryname",
                table: "FoodItems",
                column: "FoodCategoryname",
                principalTable: "FoodCategories",
                principalColumn: "name");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceModel_SignupLogin_userId",
                table: "invoiceModel",
                column: "userId",
                principalTable: "SignupLogin",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_otpModels_SignupLogin_userId",
                table: "otpModels",
                column: "userId",
                principalTable: "SignupLogin",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_SignupLogin_userId",
                table: "UserProfile",
                column: "userId",
                principalTable: "SignupLogin",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_FoodCategories_FoodCategoryname",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_invoiceModel_SignupLogin_userId",
                table: "invoiceModel");

            migrationBuilder.DropForeignKey(
                name: "FK_otpModels_SignupLogin_userId",
                table: "otpModels");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProfile_SignupLogin_userId",
                table: "UserProfile");

            migrationBuilder.RenameColumn(
                name: "profilePicture",
                table: "UserProfile",
                newName: "ProfilePicture");

            migrationBuilder.RenameColumn(
                name: "pincode",
                table: "UserProfile",
                newName: "Pincode");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "UserProfile",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mobileNumber",
                table: "UserProfile",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "UserProfile",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "UserProfile",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "profileId",
                table: "UserProfile",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserProfile",
                newName: "FKUserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserProfile_userId",
                table: "UserProfile",
                newName: "IX_UserProfile_FKUserID");

            migrationBuilder.RenameColumn(
                name: "rememberMe",
                table: "SignupLogin",
                newName: "RememberMe");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "SignupLogin",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "SignupLogin",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "SignupLogin",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "confirmPassword",
                table: "SignupLogin",
                newName: "ConfirmPassword");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "SignupLogin",
                newName: "userid");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "otpModels",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "otpModels",
                newName: "FKUserID");

            migrationBuilder.RenameIndex(
                name: "IX_otpModels_userId",
                table: "otpModels",
                newName: "IX_otpModels_FKUserID");

            migrationBuilder.RenameColumn(
                name: "orderStatus",
                table: "orders",
                newName: "OrderStatus");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "unitPrice",
                table: "orders",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "orders",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "orderDate",
                table: "orders",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "orderBill",
                table: "orders",
                newName: "Order_Bill");

            migrationBuilder.RenameColumn(
                name: "transactionId",
                table: "invoiceModel",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "invoiceModel",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "invoiceModel",
                newName: "FKUserID");

            migrationBuilder.RenameColumn(
                name: "dateOfInvoice",
                table: "invoiceModel",
                newName: "DateInvoice");

            migrationBuilder.RenameIndex(
                name: "IX_invoiceModel_userId",
                table: "invoiceModel",
                newName: "IX_invoiceModel_FKUserID");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "FoodItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "FoodItems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isVegan",
                table: "FoodItems",
                newName: "IsVegan");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "FoodItems",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "FoodItems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "FoodItems",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "calories",
                table: "FoodItems",
                newName: "Calories");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryname",
                table: "FoodItems",
                newName: "FoodCategoryName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "FoodItems",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItems_FoodCategoryname",
                table: "FoodItems",
                newName: "IX_FoodItems_FoodCategoryName");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "FoodCategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "CheckoutDetails",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "pincode",
                table: "CheckoutDetails",
                newName: "PinCode");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CheckoutDetails",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "mobileNumber",
                table: "CheckoutDetails",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "CheckoutDetails",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "CheckoutDetails",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CheckoutDetails",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_FoodCategories_FoodCategoryName",
                table: "FoodItems",
                column: "FoodCategoryName",
                principalTable: "FoodCategories",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceModel_SignupLogin_FKUserID",
                table: "invoiceModel",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_otpModels_SignupLogin_FKUserID",
                table: "otpModels",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProfile_SignupLogin_FKUserID",
                table: "UserProfile",
                column: "FKUserID",
                principalTable: "SignupLogin",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
