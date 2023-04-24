using System.Text.Json.Serialization;

namespace RefitDemo.AuthApiClient.ProductApi.Dtos;

public record ProductGetResponseAttributeValues
{
    [JsonPropertyName("DescriptionLongMarketplaces")]
    public IEnumerable<ProductGetResponseAttributeValue> DescriptionLongMarketplaces { get; init; } = Array.Empty<ProductGetResponseAttributeValue>();
    
    [JsonPropertyName("TitleShop")]
    public IEnumerable<ProductGetResponseAttributeValue> TitleShop { get; init; } = Array.Empty<ProductGetResponseAttributeValue>();
    
    [JsonPropertyName("VideoUrlInternal")]
    public IEnumerable<ProductGetResponseAttributeValue> VideoUrlInternal { get; init; } = Array.Empty<ProductGetResponseAttributeValue>();
    
    [JsonPropertyName("VideoUrlExternal")]
    public IEnumerable<ProductGetResponseAttributeValue> VideoUrlExternal { get; init; } = Array.Empty<ProductGetResponseAttributeValue>();
}