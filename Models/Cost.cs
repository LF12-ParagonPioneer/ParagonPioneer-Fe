using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Models;

public class Cost
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}