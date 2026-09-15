using BlazorFront;
using BlazorFront;
using BlazorFront.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("API", client => client.BaseAddress = new Uri("https://localhost:7xxx/"));
builder.Services.AddScoped<FichaCreationState>();
builder.Services.AddScoped<FichaAPI>();

await builder.Build().RunAsync();