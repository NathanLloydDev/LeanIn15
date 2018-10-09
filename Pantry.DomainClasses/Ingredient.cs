using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.DomainClasses
{
  public class Ingredient
  {
    public int IngredientID { get; set; }

    public string Name { get; set; }

    public int PageNumber { get; set; }

    public float CostPer100g { get; set; }

    [Key ForeignKey("Unit")]
    public int UnitID { get; set; }

    public int RecipeID { get; set; }

    public virtual Unit Unit { get; set; }

    public virtual Recipe Recipe { get; set; }
  }
}
