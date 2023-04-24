using Refit;
using RefitDemo.AuthApiClient.AuthApi.Dto;

namespace RefitDemo.AuthApiClient.AuthApi;

public interface IAuthApi
{
    [Post("/api/login")]
    public Task<IApiResponse<LoginResponse>> GetToken([Body] LoginRequest request, CancellationToken cancellationToken);
}