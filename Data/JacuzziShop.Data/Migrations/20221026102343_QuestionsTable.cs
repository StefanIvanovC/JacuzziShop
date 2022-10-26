using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JacuzziShop.Data.Migrations
{
    public partial class QuestionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jacuzzis_Categories_CategoryId",
                table: "Jacuzzis");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Jacuzzis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_AspNetUsers_AddedByUserId",
                        column: x => x.AddedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AddedByUserId",
                table: "Questions",
                column: "AddedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_IsDeleted",
                table: "Questions",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Jacuzzis_Categories_CategoryId",
                table: "Jacuzzis",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jacuzzis_Categories_CategoryId",
                table: "Jacuzzis");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Jacuzzis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Jacuzzis_Categories_CategoryId",
                table: "Jacuzzis",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
