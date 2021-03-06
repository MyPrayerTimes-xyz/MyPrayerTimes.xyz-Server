using Blazored.LocalStorage;
using myprayertimes.esolat;
using MyPrayerTimes.xyz_Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<EsolatApi>();
builder.Services.AddSingleton<ServerStorageService>();
builder.Services.AddSingleton<GitHashService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();