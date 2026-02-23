using Microsoft.EntityFrameworkCore;
using Pin.LiveSports.Blazor.Hubs;
using Pin.LiveSports.Core.Data;
using Pin.LiveSports.Core.Services;
using Pin.LiveSports.Core.Services.Interfaces;

namespace Pin.LiveSports.Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSignalR();

            // Register the IMemoryCache service
            builder.Services.AddMemoryCache();

            // Database connection
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("LolEsports")
                )
            );

            // Services
            builder.Services.AddTransient<ITeamService, TeamService>();
            builder.Services.AddTransient<IMatchService, MatchService>();
            builder.Services.AddSingleton<IMapService, MapService>();

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
            app.MapHub<MatchHub>("/matchHub");

            app.Run();
        }
    }
}