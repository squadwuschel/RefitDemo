using Refit;
using RefitDemo.AuthApiClient.AuthApi;

namespace RefitDemo.AuthApiClient.ProductApi;

public static class AddRelaxdaysProductApiDependencyInjection
{
    public static IServiceCollection AddRelaxdaysProductApiWithRefit(this IServiceCollection services)
    {
        
        services.AddRefitClient<IRelaxdaysProdroductApi>()
            .ConfigureHttpClient(p => p.BaseAddress = new Uri("https://apitest.relaxdays.de/"))
            .AddHttpMessageHandler<AuthApiAuthenticationHandler>();

        return services;
    }
    
}