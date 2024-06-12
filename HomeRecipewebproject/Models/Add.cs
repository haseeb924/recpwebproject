using System.ComponentModel.DataAnnotations;

namespace HomeRecipewebproject.Models
{
    public class Add

    {
        [Key] 
        public int RecipeId { get; set; }
   
        public string RecipeName { get; set; }
        public decimal RecipePrice { get; set; }
        public byte[] RecipeImage { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }

    }
}
