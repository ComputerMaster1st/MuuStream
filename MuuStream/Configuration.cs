using Newtonsoft.Json;

namespace MuuStream
{
    internal class Configuration
    {
        [JsonIgnore]
        private const string FILEPATH = "config.json";

        [JsonProperty]
        public string Username { get; set; } = string.Empty;

        [JsonProperty]
        public string OAuthKey { get; set; } = string.Empty;

        [JsonProperty]
        public string Channel { get; set; } = string.Empty;

        [JsonProperty]
        public bool IsUsernameAsChannel { get; set; } = false;

        public static Configuration Load()
        {
            if (File.Exists(FILEPATH))
                return JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(FILEPATH));

            var config = new Configuration();
            config.Save();
            return null;
        }

        public void Save()
            => File.WriteAllText(FILEPATH, JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}
