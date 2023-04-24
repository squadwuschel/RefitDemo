using Refit;

namespace RefitDemo.AuthApiClient.AuthApi;

public static class AddAuthApiDependencyInjection
{
    public static IServiceCollection AddAuthApiWithRefit(this IServiceCollection services)
    {
        services.AddTransient<AuthApiAuthenticationHandler>();

        services.AddRefitClient<IAuthApi>()
            .ConfigureHttpClient(p => p.BaseAddress = new Uri("https://authtest.relaxdays.de/"));

        return services;
    }
    
}