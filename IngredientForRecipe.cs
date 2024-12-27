using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{
    
    public class IngredientForRecipe : ICloneable
    {
        [Browsable(false)]
        [JsonPropertyName("recipe_name")]
        [Description("Название рецепта")]
        public string RecipeName { get; set; } = string.Empty;

        [JsonPropertyName("ingredient_name")]
        [Description("Наименование ингридиента")]
        [DisplayName("Ингридиент")]
        public string IngredientName { get; set; } = string.Empty;

        [JsonPropertyName("ingredient_quantity")]
        [Description("Количество ингридиента")]
        [DisplayName("Количество")]
        public int IngredientQuantity { get; set; }

        public object Clone()
        {
            IngredientForRecipe res = new()
            {
                RecipeName = RecipeName,
                IngredientName = IngredientName,
                IngredientQuantity = IngredientQuantity
            };
            return res;
        }
    }
}
