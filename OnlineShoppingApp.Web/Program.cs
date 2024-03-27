using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineShoppingApp.Web;
using OnlineShoppingApp.Web.Services;
using OnlineShoppingApp.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7277/") }); //Base Adres tan�mlama(AP�)

builder.Services.AddScoped<IProductService,ProductService>(); //Servisleri tan�mlama
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>(); //Servisleri tan�mlama

await builder.Build().RunAsync();















//Kullan�lan Api Adresleri

//1- https://localhost:7277/api/Product �r�nleri listele