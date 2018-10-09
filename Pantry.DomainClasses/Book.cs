using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.DomainClasses
{
  public class Book
  {
    private ICollection<Recipe> _recipes;

    public Book()
    {
      _recipes = new List<Recipe>();
    }

    public int BookID { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Recipe> Recipes
    {
      get { return _recipes; }
      set { _recipes = value; }
    }
  }
}
