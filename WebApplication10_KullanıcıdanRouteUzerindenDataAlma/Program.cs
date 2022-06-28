var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();
app.UseRouting();

app.UseStaticFiles();

app.MapControllerRoute(
     name: "default",
    pattern: "{controller=Product}/{action=Index}/{a?}/{b?}/{id?}");

app.Run();
