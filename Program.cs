using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalWebsite;
using PersonalWebsite.Data;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress);

await builder.Build().RunAsync();

static void ConfigureServices(IServiceCollection services, string baseAddress)
{
    // Nuget package for handing some head tags, compatible with prerendering.
    // The built-in feature for head tags management creates duplicate tags (see #33).
    services.AddHeadElementHelper();
    
    services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });
    services.AddSingleton<PublicationList>();
}