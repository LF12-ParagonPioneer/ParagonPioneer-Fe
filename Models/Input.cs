﻿using System.Text.Json.Serialization;

namespace ParagonPioneerFe.Models;

public class Input
{
    [JsonPropertyName("quantity")]
    public required int Quantity { get; set; }
    
    [JsonPropertyName("good")]
    public Good? Good { get; set; }
}