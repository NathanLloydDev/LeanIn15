using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.DomainClasses
{
  public class Recipe
  {
    private ICollection<Ingredient> _ingredients;
    //private ICollection<Step> _steps;

    public Recipe()
    {
      _ingredients = new List<Ingredient>();
     // _steps = new List<Step>();
    }

    public int RecipeID { get; set; }

    public string Name { get; set; }

    public int PageNumber { get; set; }

    public int BookID { get; set; }

    public virtual ICollection<Ingredient> Ingredients
    {
      get { return _ingredients; }
      set { _ingredients = value; }
    }

    //public virtual ICollection<Step> Steps
    //{
    //  get { return _steps; }
    //  set { _steps = value; }
    //}

    public virtual Book Book { get; set; }
  }
}
