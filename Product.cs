using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{
    public class Product : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Наименование продукции")]
        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        public object Clone()
        {
            Product res = new()
            {
                Name = this.Name
            };
            return res;
        }
    }
}
