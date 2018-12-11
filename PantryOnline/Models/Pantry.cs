using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PantryOnline.Models
{
  public class Pantry
  {
    public int ID { get; set; }

    public string Name { get; set; }

    [ForeignKey("UserForeignKey")]
    public User User { get; set; }

    public List<PantryIngredient> PantryIngredients { get; set; }
  }
}