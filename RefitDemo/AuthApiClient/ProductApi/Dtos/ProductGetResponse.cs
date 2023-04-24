using System.Text.Json.Serialization;

namespace RefitDemo.AuthApiClient.ProductApi.Dtos;

public class ProductGetResponse
{
    [JsonPropertyName("CharacteristicId")]
    public string? CharacteristicId { get; init; }
    
    [JsonPropertyName("Attributes")]
    public ProductGetResponseAttributeValues Attributes { get; set; } = new();
}