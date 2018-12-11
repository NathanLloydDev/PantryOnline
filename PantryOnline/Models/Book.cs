using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PantryOnline.Models
{
  public class Book
  {
    public int ID { get; set; }

    public string Name { get; set; }

    public List<Recipe> Recipes { get; set; }
  }
}