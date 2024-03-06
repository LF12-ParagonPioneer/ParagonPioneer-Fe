using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ParagonPioneerFe.Models;

public class Recipe
{
    [JsonPropertyName("id")] 
    public required string Id { get; set; }

    [JsonPropertyName("output")]
    public required Good Output { get; set; }
    
    [JsonPropertyName("quantityOfGoods")]
    public required List<Input> QuantityOfGoods { get; set; }
    
}