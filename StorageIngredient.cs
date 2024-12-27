using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{   
    public class StorageIngredient : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Наименование ингридиента")]
        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        [Description("Количество ингридиента на складе")]
        [DisplayName("Количество")]
        public int Quantity { get; set; }

        public object Clone()
        {
            StorageIngredient res = new()
            {
                Name = Name,
                Quantity = Quantity,
            };
            return res;
        }
    }
}
