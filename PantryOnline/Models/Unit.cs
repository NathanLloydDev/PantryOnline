using System;
using System.ComponentModel.DataAnnotations;

namespace PantryOnline.Models
{
  public class Unit
  {
    public int ID { get; set; }

    public string Name { get; set; }

    public string Abbreviation { get; set; }

    [Display(Name = "Is Base Unit")]
    public bool IsBaseUnit { get; set; }
  }
}