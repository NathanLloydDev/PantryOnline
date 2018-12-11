using Microsoft.EntityFrameworkCore.Migrations;

namespace PantryOnline.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Pantry_PantrysID",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Recipe_RecipesID",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_PantrysID",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_RecipesID",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "PantrysID",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "RecipesID",
                table: "Ingredient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PantrysID",
                table: "Ingredient",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipesID",
                table: "Ingredient",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_PantrysID",
                table: "Ingredient",
                column: "PantrysID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_RecipesID",
                table: "Ingredient",
                column: "RecipesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Pantry_PantrysID",
                table: "Ingredient",
                column: "PantrysID",
                principalTable: "Pantry",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Recipe_RecipesID",
                table: "Ingredient",
                column: "RecipesID",
                principalTable: "Recipe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
