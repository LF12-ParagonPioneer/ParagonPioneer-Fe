using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Components.Models;

public class Building
{
    [JsonPropertyName("id")] 
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("costs")] 
    public List<Cost> Costs { get; set; } = new();
}