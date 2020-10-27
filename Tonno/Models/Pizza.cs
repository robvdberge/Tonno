using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Tonno.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        [DisplayName("Soort pizza")]
        public Boolean PizzaSoort { get; set; }

        [DisplayName("Topping 1")]
        public int IngredientId1 { get; set; }

        [DisplayName("Topping 2")]
        public int IngredientId2 { get; set; }

        [DisplayName("Topping 3")]
        public int IngredientId3 { get; set; }

        [DisplayName("Prijs")]
        [DefaultValue("4")]
        public decimal Price { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}