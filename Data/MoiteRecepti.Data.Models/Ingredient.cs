namespace MoiteRecepti.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MoiteRecepti.Data.Common.Models;

    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<RecipeIngredient>();
        }

        public string Name { get; set; }

        public ICollection<RecipeIngredient> Recipes { get; set; }
    }
}
