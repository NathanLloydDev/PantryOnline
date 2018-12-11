using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PantryOnline.Models
{
  public class Ingredient
  {
    public int ID { get; set; }

    public string Name { get; set; }

    [Display(Name = "Cost Per 100g")]
    public double CostPer100g { get; set; }

    [ForeignKey("UnitForeignKey")]
    public Unit Unit { get; set; }

    [ForeignKey("TypeForeignKey")]
    public IngredientType Type { get; set; }

    [Display(Name = "Weight Per 100g")]
    public double WeightPerUnit { get; set; }

    public List<RecipeIngredient> RecipeIngredients { get; set; }

    public List<PantryIngredient> PantryIngredients { get; set; }
  }
}