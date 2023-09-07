using Microsoft.EntityFrameworkCore.Migrations;

namespace P01_BillsPaymentSystem.Data.Migrations
{
    public partial class addingModelBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaymentMethods_UserId",
                table: "PaymentMethods");

            migrationBuilder.CreateCheckConstraint(
                name: "BankAccountIdOrCreditCardId",
                table: "PaymentMethods",
                sql: @"(BankAccountId IS NULL AND CreditCardId IS NOT NULL) OR 
     (BankAccountId IS NOT NULL AND CreditCardId IS NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_UserId_CreditCardId_BankAccountId",
                table: "PaymentMethods",
                columns: new[] { "UserId", "CreditCardId", "BankAccountId" },
                unique: true,
                filter: "[CreditCardId] IS NOT NULL AND [BankAccountId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaymentMethods_UserId_CreditCardId_BankAccountId",
                table: "PaymentMethods");

            migrationBuilder.DropCheckConstraint(
                name: "BankAccountIdOrCreditCardId",
                table: "PaymentMethods");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_UserId",
                table: "PaymentMethods",
                column: "UserId");
        }
    }
}
