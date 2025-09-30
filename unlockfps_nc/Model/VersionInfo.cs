using System.Text.Json.Serialization;

namespace unlockfps.Model
{
    public class VersionInfo
    {
        [JsonPropertyName("Version")]
        public int Version { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; } = string.Empty;
    }
}
