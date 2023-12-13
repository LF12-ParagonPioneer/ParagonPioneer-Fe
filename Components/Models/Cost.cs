using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Components.Models;

public class Cost
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}