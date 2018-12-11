using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PantryOnline.Models
{
  public class Recipe
  {
    public int ID { get; set; }

    public string Name { get; set; }

    [ForeignKey("BookForeignKey")]
    public Book Book { get; set; }

    [Display(Name = "Page Number")]
    public int PageNumber { get; set; }

    [Display(Name = "Make Ahead")]
    public bool MakeAhead { get; set; }

    [Display(Name = "Longer Recipe")]
    public bool LongerRecipe { get; set; }

    [Display(Name = "Good To Freeze")]
    public bool GoodToFreeze { get; set; }

    [Display(Name = "Ingredients Complete")]
    public bool IngredientsComplete { get; set; }

    [Display(Name = "Steps Complete")]
    public bool StepsComplete { get; set; }

    public List<RecipeIngredient> RecipeIngredients { get; set; }
  }
}