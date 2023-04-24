using System.Text.Json.Serialization;

namespace RefitDemo.AuthApiClient.AuthApi.Dto;

public class LoginResponse
{
    [JsonPropertyName("token")]
    public required string Token { get; init; }
}