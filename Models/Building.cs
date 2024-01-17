﻿using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Models;

public class Building
{
    [JsonPropertyName("id")] 
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("costs")] 
    public List<Cost> Costs { get; set; } = new();
}