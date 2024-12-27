using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{
    
    public class Ingredient : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Наименование ингридиента")]
        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        public object Clone()
        {
            Ingredient res = new ()
            {
                Name = Name
            };
            return res;
        }
    }
}
