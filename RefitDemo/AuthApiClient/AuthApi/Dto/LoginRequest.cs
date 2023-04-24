using System.Text.Json.Serialization;

namespace RefitDemo.AuthApiClient.AuthApi.Dto;

public class LoginRequest
{
    private static readonly int RelaxdaysLoginTypeUsername = 1;

    [JsonPropertyName("username")]
    public required string Username { get; init; }

    [JsonPropertyName("password")]
    public required string Password { get; init; }

    [JsonPropertyName("loginType")]
    public int LoginType { get; } = RelaxdaysLoginTypeUsername;
}