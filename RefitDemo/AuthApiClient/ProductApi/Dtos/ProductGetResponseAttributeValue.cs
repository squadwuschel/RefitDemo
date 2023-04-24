using System.Text.Json.Serialization;

namespace RefitDemo.AuthApiClient.ProductApi.Dtos;

public class ProductGetResponseAttributeValue
{
    [JsonPropertyName("Value")]
    public string? Value { get; init; }
}