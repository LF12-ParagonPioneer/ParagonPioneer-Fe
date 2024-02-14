using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Models;

public class Recipe
{
    [JsonPropertyName("id")] 
    public required string Id { get; set; }

    [JsonPropertyName("output")]
    public required Good Output { get; set; }
    
    [JsonPropertyName("inputs")]
    public required List<Input> Inputs { get; set; }
    
}