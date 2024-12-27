using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{   
    public class Recipe : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Наименование рецета")]
        [DisplayName("Рецепт")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_name")]
        [Description("Наименование продукции")]
        [DisplayName("Продукция")]
        public string ProductName { get; set; } = string.Empty;

        [JsonPropertyName("product_quantity")]
        [Description("Количество продукции при выполнении этого рецепта")]
        [DisplayName("Количество продукции")]
        public int ProductQuanity { get; set; }

        public object Clone()
        {
            Recipe res = new()
            {
                Name = this.Name,
                ProductName = this.ProductName,
                ProductQuanity = this.ProductQuanity
            };
            return res;
        }
    }
}
