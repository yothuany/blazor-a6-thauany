using BlazorApp.Components;
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adiciona os serviços do Blazor
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Recupera a string de conexão do appsettings.json
            var connectionString = builder.Configuration
                .GetConnectionString("LojaConnection")
                ?? throw new InvalidOperationException(
                    "String de conexão não encontrada.");

            // Registra a fábrica de contextos do Entity Framework
            builder.Services.AddDbContextFactory<LojaContext>(options =>
                options.UseMySQL(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute(
                "/not-found",
                createScopeForStatusCodePages: true);

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}