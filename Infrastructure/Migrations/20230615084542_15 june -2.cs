using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _15june2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDelivery_Bill_OrderId",
                table: "HomeDelivery");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Bill_BillId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_BillId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "HomeDelivery");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "HomeDelivery");

            migrationBuilder.DropColumn(
                name: "CustomerFname",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "CustomerLname",
                table: "Bill",
                newName: "BillNumber");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Bill",
                newName: "OrderId");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "OrderDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "BaseLineTotal",
                table: "Bill",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DiscountAmount",
                table: "Bill",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TaxAmount",
                table: "Bill",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TableId = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Orders_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "TableId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_OrderId",
                table: "Bill",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                column: "TableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Orders_OrderId",
                table: "Bill",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDelivery_Orders_OrderId",
                table: "HomeDelivery",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Orders_OrderId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeDelivery_Orders_OrderId",
                table: "HomeDelivery");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Bill_OrderId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "BaseLineTotal",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "TaxAmount",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Bill",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "BillNumber",
                table: "Bill",
                newName: "CustomerLname");

            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Table",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BillId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "HomeDelivery",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "HomeDelivery",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerFname",
                table: "Bill",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_BillId",
                table: "OrderDetails",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDelivery_Bill_OrderId",
                table: "HomeDelivery",
                column: "OrderId",
                principalTable: "Bill",
                principalColumn: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Bill_BillId",
                table: "OrderDetails",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "BillId");
        }
    }
}
