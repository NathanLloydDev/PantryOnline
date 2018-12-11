using System;
using System.ComponentModel.DataAnnotations;

namespace PantryOnline.Models
{
  public class User
  {
    public int ID { get; set; }

    public string Name { get; set; }

    [Display(Name = "Email Address")]
    public string EmailAddress { get; set; }
  }
}