using Microsoft.EntityFrameworkCore;
using OuterrimAirship.Components;
using OuterrimAirship.Model;

var builder = WebApplication.CreateBuilder(args);

// Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Database
builder.Services.AddDbContextFactory<AircraftContext>(options =>
    options.UseSqlite($"DataSource=./DB/Aircrafts.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Other
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Blazor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();