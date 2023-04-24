using System.Net.Http.Headers;
using Microsoft.Extensions.Options;
using RefitDemo.AuthApiClient.AuthApi.Configuration;
using RefitDemo.AuthApiClient.AuthApi.Dto;

namespace RefitDemo.AuthApiClient.AuthApi;

public class AuthApiAuthenticationHandler :DelegatingHandler
{
    private readonly IAuthApi _authApiAuthenticationClient;
    private readonly IOptions<TaskUserConfiguration> _taskUserConfiguration;

    public AuthApiAuthenticationHandler(
        IAuthApi authApiAuthenticationClient,
        IOptions<TaskUserConfiguration> taskUserConfiguration)
    {
        _authApiAuthenticationClient = authApiAuthenticationClient;
        _taskUserConfiguration = taskUserConfiguration;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var loginRequest = new LoginRequest()
        {
            Username = _taskUserConfiguration.Value.Username,
            Password = _taskUserConfiguration.Value.Password
        };
        
        var token = await _authApiAuthenticationClient.GetToken(loginRequest, cancellationToken);
        
        var loginFailed = token.IsSuccessStatusCode == false;
        if (loginFailed)
        {
            throw new Exception("Could not get token from auth api");
        }
        
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.Content.Token);
        
        return await base.SendAsync(request, cancellationToken);
    }
}