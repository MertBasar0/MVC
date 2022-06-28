var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

//app.MapDefaultControllerRoute();


app.Run();
