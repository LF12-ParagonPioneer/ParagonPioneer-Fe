using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Services.Models;

public class Paged<T>
{
    [JsonPropertyName("content")]
    public required List<T> Content { get; set; }
    
    [JsonPropertyName("pageable")]
    public required Pageable Pageable { get; set; }
    
    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }
    
    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }
    
    [JsonPropertyName("size")]
    public int Size { get; set; }
}