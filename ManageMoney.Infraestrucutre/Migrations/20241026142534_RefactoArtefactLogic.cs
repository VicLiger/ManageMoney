using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageMoney.Infraestrucutre.Migrations
{
    /// <inheritdoc />
    public partial class RefactoArtefactLogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investments_Performances_PerfomanceId",
                table: "Investments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Consumption_CashId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Investments_PerfomanceId",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "PerfomanceId",
                table: "Investments");

            migrationBuilder.RenameColumn(
                name: "CashId",
                table: "Users",
                newName: "FinancialObjectiveId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CashId",
                table: "Users",
                newName: "IX_Users_FinancialObjectiveId");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountCashId1",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Investments",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Consumption",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountCashId1",
                table: "Users",
                column: "AccountCashId1");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_UserId",
                table: "Investments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumption_UserId",
                table: "Consumption",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumption_Users_UserId",
                table: "Consumption",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_Users_UserId",
                table: "Investments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AccountCash_AccountCashId1",
                table: "Users",
                column: "AccountCashId1",
                principalTable: "AccountCash",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_FinancialObjectives_FinancialObjectiveId",
                table: "Users",
                column: "FinancialObjectiveId",
                principalTable: "FinancialObjectives",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumption_Users_UserId",
                table: "Consumption");

            migrationBuilder.DropForeignKey(
                name: "FK_Investments_Users_UserId",
                table: "Investments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_AccountCash_AccountCashId1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_FinancialObjectives_FinancialObjectiveId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AccountCashId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Investments_UserId",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Consumption_UserId",
                table: "Consumption");

            migrationBuilder.DropColumn(
                name: "AccountCashId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Investments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Consumption");

            migrationBuilder.RenameColumn(
                name: "FinancialObjectiveId",
                table: "Users",
                newName: "CashId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_FinancialObjectiveId",
                table: "Users",
                newName: "IX_Users_CashId");

            migrationBuilder.AddColumn<Guid>(
                name: "PerfomanceId",
                table: "Investments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InvestimentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Value = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Investments_InvestimentId",
                        column: x => x.InvestimentId,
                        principalTable: "Investments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investments_PerfomanceId",
                table: "Investments",
                column: "PerfomanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_InvestimentId",
                table: "Performances",
                column: "InvestimentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_Performances_PerfomanceId",
                table: "Investments",
                column: "PerfomanceId",
                principalTable: "Performances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Consumption_CashId",
                table: "Users",
                column: "CashId",
                principalTable: "Consumption",
                principalColumn: "Id");
        }
    }
}
