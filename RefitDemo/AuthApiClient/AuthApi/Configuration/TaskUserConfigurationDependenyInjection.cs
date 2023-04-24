namespace RefitDemo.AuthApiClient.AuthApi.Configuration;

public static class TaskUserConfigurationDependenyInjection
{
    public static IServiceCollection AddTaskUserConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .Configure<TaskUserConfiguration>(configuration.GetSection("TaskUser"));
        
        return services;
    }
    
}