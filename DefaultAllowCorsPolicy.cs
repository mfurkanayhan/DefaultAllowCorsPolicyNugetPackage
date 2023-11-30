using Microsoft.Extensions.DependencyInjection;

namespace DefaultAllowCorsPolicyNugetPackage;
public static class DefaultAllowCorsPolicy
{
    public static IServiceCollection AddDefaultCors(this IServiceCollection services)
    {
        services.AddCors(cfr =>
        {
            cfr.AddDefaultPolicy(policy =>
            {
                policy
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .SetIsOriginAllowed(policy => true);
            });
        });

        return services;
    }
}
//03:10:35