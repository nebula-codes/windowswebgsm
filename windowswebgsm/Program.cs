using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using windowswebgsm.Data;
using MudBlazor.Services;
using windowswebgsm.data;
using Microsoft.EntityFrameworkCore;
using windowswebgsm.data.Services;
using windowswebgsm.data.Logic;
using MudBlazor;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = true;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 1500;
    config.SnackbarConfiguration.HideTransitionDuration = 100;
    config.SnackbarConfiguration.ShowTransitionDuration = 100;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
});

builder.Services.AddScoped<GameServerService>();



#region Connection String
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("maincon"));
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

Helper helper = new();
helper.GenerateDirectories();

if (!File.Exists(Path.Combine(helper.SteamBin, "steamcmd.zip")))
{
    await helper.DownloadSteamCMD();
}

app.Run();