using Refit;

namespace RefitDemo.SwapiWithoutAuth;

public static class SwApiDependencyInjection
{
    public static IServiceCollection AddSwApiWithRefit(this IServiceCollection services)
    {
        services.AddRefitClient<ISwapi>()
            .ConfigureHttpClient(p => p.BaseAddress = new Uri("https://swapi.dev/"));

        return services;
    }
}