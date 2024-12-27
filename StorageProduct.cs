using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{
    public class StorageProduct : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Наименование готовой продукции")]
        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("quantity")]
        [Description("Количество готовой продукции на складе")]
        [DisplayName("Количество")]
        public int Quantity { get; set; }

        public object Clone()
        {
            StorageProduct res = new()
            {
                Name = Name,
                Quantity = Quantity,
            };
            return res;
        }
    }
}
