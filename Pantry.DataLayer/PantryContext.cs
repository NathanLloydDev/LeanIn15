using Pantry.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.DataLayer
{
  public class PantryContext : DbContext
  {
    public DbSet<Book> Book { get; set; }

    public DbSet<Recipe> Recipe { get; set; }

    public DbSet<Ingredient> Ingredient { get; set; }

    public DbSet<Unit> Unit { get; set; }
  }
}
