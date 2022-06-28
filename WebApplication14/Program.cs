using FluentValidation.AspNetCore;
using WebApplication14_FluentValidation.Models.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<ProductValidator>());
var app = builder.Build();

app.UseAuthorization();

app.UseHttpsRedirection();

app.UseRouting();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();


