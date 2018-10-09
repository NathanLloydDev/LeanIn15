using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantry.DomainClasses
{
  public class Unit
  {
    public int UnitID { get; set; }

    public string Name { get; set; }

    public bool IsBaseUnit { get; set; }

    [Key ForeignKey("Ingredient")]
    public int IngredientID { get; set; }

    public virtual Ingredient Ingredient { get; set; }
  }
}
