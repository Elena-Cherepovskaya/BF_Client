using System.ComponentModel;
using System.Text.Json.Serialization;

namespace BF_Client
{
    public enum Rule
    {
        Admin,
        Edit,
        Client,
    };

    public class UserLogin
    {
        [JsonPropertyName("name")]
        [Description("Используется для входа в систему")]
        [DisplayName("Имя")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("password")]
        [Description("Используется для входа в систему")]
        [DisplayName("Пароль")]
        [PasswordPropertyText(true)]
        public string Password { get; set; } = string.Empty;
    }

    public class UserAdd : UserLogin
    {
        [JsonPropertyName("rule")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Description("Задачи решаемые пользователем")]
        [DisplayName("Права")]
        public Rule Rule { get; set; } = Rule.Client;
    }

    public class User : ICloneable
    {
        [JsonPropertyName("name")]
        [Description("Используется для входа в систему")]
        [DisplayName("Имя")]
        public string Name { set; get; } = string.Empty;

        [JsonPropertyName("rule")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Description("Задачи решаемые пользователем")]
        [DisplayName("Права")]
        public Rule Rule { get; set; } = Rule.Client;

        public object Clone()
        {
            var clone = new User
            {
                Name = Name,
                Rule = Rule
            };
            return clone;
        }
    }
}
