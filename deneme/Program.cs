using Microsoft.AspNetCore.Mvc;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//builder.Services.AddDbContext();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "product",
    pattern: "/product-details/{id?}",
    defaults: new { controller = "Product", action = "ProductDetails" });

app.MapControllerRoute(
    name: "shop",
    pattern: "/shop/{id?}",
    defaults: new { controller = "Product", action = "Shop" });


app.MapControllerRoute(
   name: "register",
   pattern: "/register/{id?}",
   defaults: new { controller = "Register", action = "Index" });

app.MapControllerRoute(
   name: "basket",
   pattern: "/basket/{id?}",
   defaults: new { controller = "Product", action = "Basket" });



app.Run();
