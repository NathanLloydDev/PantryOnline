using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantryOnline.Models
{
  public class PantryIngredient
  {
    public int ID { get; set; }

    public int PantryID { get; set; }

    public Pantry Pantry { get; set; }

    public int IngredientID { get; set; }

    public Ingredient Ingredient { get; set; }

  }
}