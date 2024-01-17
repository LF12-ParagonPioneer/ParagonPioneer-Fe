﻿using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Models;

public class Good
{
    [JsonPropertyName("id")] 
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}