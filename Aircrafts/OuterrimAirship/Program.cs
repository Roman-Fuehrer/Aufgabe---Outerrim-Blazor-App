using Microsoft.EntityFrameworkCore;
using OuterrimAirship.Components;
using OuterrimAirship.Model;
using OuterrimAirship.Repositories.Base;
using OuterrimAirship.Repositories.Implemented;

var builder = WebApplication.CreateBuilder(args);

// Blazor
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Database
builder.Services.AddDbContextFactory<SpacecraftContext>(options =>
    options.UseSqlite($"DataSource=./DB/Spacecrafts.db"));

// Repositories
builder.Services.AddScoped<IRepositoryAsync<Spacecraft>, SpacecraftRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<Compartment>, CompartmentRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<Machinery>, MachineryRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<Mercenary>, MercenaryRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<MercenaryReputation>, MercenaryReputationRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<CrimeSyndicate>, CrimeSyndicateRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<Crew>, CrewRepositoryAsync>();
builder.Services.AddScoped<IRepositoryAsync<SpacecraftSpecification>, SpacecraftSpecificationRepositoryAsync>();

// Logging
builder.Services.AddScoped<Logger<Program>>();

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