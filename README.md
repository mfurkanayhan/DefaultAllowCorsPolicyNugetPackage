![cors](https://github.com/mfurkanayhan/DefaultAllowCorsPolicyNugetPackage/assets/75537063/1649bf54-7721-4040-9c18-62719c7b0554)

# DefaultAllowCorsPolicy NuGet Package
This NuGet package facilitates adding a default Cross-Origin Resource Sharing (CORS) policy to your ASP.NET Core projects.

## Installation

To add the package to your project, you can use either the Package Manager Console or the .NET CLI:

```bash
dotnet add package DefaultAllowCorsPolicyNugetPackage

or

Install-Package DefaultAllowCorsPolicyNugetPackage

```


## Usage

After adding the package to your project, you can register the service in your `Startup.cs` file as follows:

```bash
using DefaultAllowCorsPolicyNugetPackage;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    // ...

    public void ConfigureServices(IServiceCollection services)
    {
        // Other service configurations

        // Add DefaultAllowCorsPolicy
        services.AddDefaultCors();

        // ...
    }

    // ...
}
```
This adds a CORS policy allowing all requests.

## CORS Policy

This package adds a CORS policy that allows all headers, all methods, credentials, and allows any origin. This policy can be useful during development or in scenarios where specific security requirements are not necessary. It is recommended to customize the policy for security requirements.

```bash
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
```

## Licence

This project is licensed under the MIT License.

```bash
This sample README file provides essential information regarding the installation, usage, and CORS policy of the project.
```
