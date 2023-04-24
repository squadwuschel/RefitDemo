using System.Text.Json.Serialization;

namespace RefitDemo.SwapiWithoutAuth.Dtos;

public class PersonResponse
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    
    [JsonPropertyName("birth_year")]
    public required string BirthYear { get; init; }
    
    [JsonPropertyName("eye_color")]
    public required string EyeColor { get; init; }
    
    [JsonPropertyName("films")]
    public required List<string> Films { get; init; }
    
    [JsonPropertyName("gender")]
    public required string Gender { get; init; }
}