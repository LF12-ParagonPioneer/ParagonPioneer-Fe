using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Services.Models;

public class Pageable
{
    [JsonPropertyName("pageNumber")]
    public int PageNumber { get; set; }
    
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; }
    
    [JsonPropertyName("paged")]
    public bool Paged { get; set; }
}