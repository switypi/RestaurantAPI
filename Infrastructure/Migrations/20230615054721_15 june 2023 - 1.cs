using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _15june20231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_OrderDetails_OrderDetailsOrderId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Bill_OrderBillId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderBillId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Menu_OrderDetailsOrderId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "OrderDetailsOrderId",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Table",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "OrderBillId",
                table: "OrderDetails",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Menu",
                newName: "IsVeg");

            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Table",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "TableType",
                table: "Table",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OrderId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<long>(
                name: "OrderDetailId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "OrderDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customer",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BillId",
                table: "OrderDetails",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Bill_BillId",
                table: "OrderDetails",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "BillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Bill_BillId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_BillId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "TableType",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "Table",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderDetails",
                newName: "OrderBillId");

            migrationBuilder.RenameColumn(
                name: "IsVeg",
                table: "Menu",
                newName: "Quantity");

            migrationBuilder.AlterColumn<long>(
                name: "OrderId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<long>(
                name: "OrderDetailsOrderId",
                table: "Menu",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderBillId",
                table: "OrderDetails",
                column: "OrderBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_OrderDetailsOrderId",
                table: "Menu",
                column: "OrderDetailsOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_OrderDetails_OrderDetailsOrderId",
                table: "Menu",
                column: "OrderDetailsOrderId",
                principalTable: "OrderDetails",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Bill_OrderBillId",
                table: "OrderDetails",
                column: "OrderBillId",
                principalTable: "Bill",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
