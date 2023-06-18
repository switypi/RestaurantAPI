using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Waiter_WaiterId",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "Bdate",
                table: "DeliveryBoy");

            migrationBuilder.AlterColumn<long>(
                name: "WaiterId",
                table: "Table",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JoinDate",
                table: "DeliveryBoy",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Waiter_WaiterId",
                table: "Table",
                column: "WaiterId",
                principalTable: "Waiter",
                principalColumn: "WaiterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Waiter_WaiterId",
                table: "Table");

            migrationBuilder.AlterColumn<long>(
                name: "WaiterId",
                table: "Table",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "JoinDate",
                table: "DeliveryBoy",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<byte[]>(
                name: "Bdate",
                table: "DeliveryBoy",
                type: "BLOB",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Waiter_WaiterId",
                table: "Table",
                column: "WaiterId",
                principalTable: "Waiter",
                principalColumn: "WaiterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
