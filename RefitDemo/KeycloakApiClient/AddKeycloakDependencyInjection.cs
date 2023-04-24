using BasicApiHelper.Keycloak;
using Refit;

namespace RefitDemo.KeycloakApiClient;

public static class AddKeycloakDependencyInjection
{
    public static IServiceCollection AddKeycloakAuthenticationWithRefit(
        this IServiceCollection services)
    {
        services.AddKeycloak("keycloak.json", options =>
        {
            options.UnauthorizedResultType = KeycloakUnauthorizedResultType.Forbid;
        });
        
        services
            //.AddRefitClient<IContentApiService>($"{KeycloakDefaults.ClientTokenHttpClientBaseName}staging", null)
            .AddRefitClient<IContentApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7288"));

        return services;
    }
    
}