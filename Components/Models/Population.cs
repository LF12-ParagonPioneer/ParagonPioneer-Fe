using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Components.Models;

public class Population
{
    [JsonPropertyName("id")] 
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}