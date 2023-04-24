using Refit;

namespace RefitDemo.AuthApiClient.ProductApi.Dtos;

public class ProductGetRequest
{
    [AliasAs("attributeCodes")]
    public required string Attributes { get; init; }
    
    [AliasAs("attributeLocales")]
    public string AttributeLocales => "de_DE";
}