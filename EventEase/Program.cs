using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<EventEase.Services.EventService>();
builder.Services.AddSingleton<EventEase.Services.UserSessionService>(); // Register UserSessionService
builder.Services.AddSingleton<EventEase.Services.AttendanceService>(); // Register AttendanceService

await builder.Build().RunAsync();
