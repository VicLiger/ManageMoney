using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManageMoney.Infraestrucutre.Migrations
{
    /// <inheritdoc />
    public partial class AddEntitiesConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCashe_Users_UserAccountId",
                table: "AccountCashe");

            migrationBuilder.DropForeignKey(
                name: "FK_Performance_Investiment_InvestimentId",
                table: "Performance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performance",
                table: "Performance");

            migrationBuilder.DropIndex(
                name: "IX_Performance_InvestimentId",
                table: "Performance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investiment",
                table: "Investiment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialObjective",
                table: "FinancialObjective");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountCashe",
                table: "AccountCashe");

            migrationBuilder.DropIndex(
                name: "IX_AccountCashe_UserAccountId",
                table: "AccountCashe");

            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "AccountCashe");

            migrationBuilder.RenameTable(
                name: "Performance",
                newName: "Performances");

            migrationBuilder.RenameTable(
                name: "Investiment",
                newName: "Investments");

            migrationBuilder.RenameTable(
                name: "FinancialObjective",
                newName: "FinancialObjectives");

            migrationBuilder.RenameTable(
                name: "AccountCashe",
                newName: "AccountCash");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "character varying(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Consumption",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Consumption",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Consumption",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Performances",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Performances",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Investments",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Investments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "FinancialObjectives",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "FinancialObjectives",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AccountCash",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "AccountCash",
                type: "numeric(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performances",
                table: "Performances",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investments",
                table: "Investments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialObjectives",
                table: "FinancialObjectives",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountCash",
                table: "AccountCash",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_InvestimentId",
                table: "Performances",
                column: "InvestimentId");

            migrationBuilder.CreateIndex(
                name: "IX_Investments_PerfomanceId",
                table: "Investments",
                column: "PerfomanceId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCash_UserId",
                table: "AccountCash",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCash_Users_UserId",
                table: "AccountCash",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investments_Performances_PerfomanceId",
                table: "Investments",
                column: "PerfomanceId",
                principalTable: "Performances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Investments_InvestimentId",
                table: "Performances",
                column: "InvestimentId",
                principalTable: "Investments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCash_Users_UserId",
                table: "AccountCash");

            migrationBuilder.DropForeignKey(
                name: "FK_Investments_Performances_PerfomanceId",
                table: "Investments");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Investments_InvestimentId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performances",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_InvestimentId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Investments",
                table: "Investments");

            migrationBuilder.DropIndex(
                name: "IX_Investments_PerfomanceId",
                table: "Investments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialObjectives",
                table: "FinancialObjectives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountCash",
                table: "AccountCash");

            migrationBuilder.DropIndex(
                name: "IX_AccountCash_UserId",
                table: "AccountCash");

            migrationBuilder.RenameTable(
                name: "Performances",
                newName: "Performance");

            migrationBuilder.RenameTable(
                name: "Investments",
                newName: "Investiment");

            migrationBuilder.RenameTable(
                name: "FinancialObjectives",
                newName: "FinancialObjective");

            migrationBuilder.RenameTable(
                name: "AccountCash",
                newName: "AccountCashe");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Consumption",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Consumption",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Consumption",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Performance",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Performance",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Investiment",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Investiment",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "FinancialObjective",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "FinancialObjective",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AccountCashe",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "AccountCashe",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18,2)");

            migrationBuilder.AddColumn<Guid>(
                name: "UserAccountId",
                table: "AccountCashe",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performance",
                table: "Performance",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Investiment",
                table: "Investiment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialObjective",
                table: "FinancialObjective",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountCashe",
                table: "AccountCashe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_InvestimentId",
                table: "Performance",
                column: "InvestimentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountCashe_UserAccountId",
                table: "AccountCashe",
                column: "UserAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCashe_Users_UserAccountId",
                table: "AccountCashe",
                column: "UserAccountId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Performance_Investiment_InvestimentId",
                table: "Performance",
                column: "InvestimentId",
                principalTable: "Investiment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
