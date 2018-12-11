using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PantryOnline.Models;

namespace PantryOnline.Models
{
  public class PantryOnlineContext : DbContext
  {
    public PantryOnlineContext(DbContextOptions<PantryOnlineContext> options)
        : base(options)
    {
    }
    public DbSet<PantryOnline.Models.Book> Book { get; set; }
    public DbSet<PantryOnline.Models.Recipe> Recipe { get; set; }
    public DbSet<PantryOnline.Models.User> User { get; set; }
    public DbSet<PantryOnline.Models.Unit> Unit { get; set; }
    public DbSet<PantryOnline.Models.Pantry> Pantry { get; set; }
    public DbSet<PantryOnline.Models.IngredientType> IngredientType { get; set; }
    public DbSet<PantryOnline.Models.Ingredient> Ingredient { get; set; }
  }
}
