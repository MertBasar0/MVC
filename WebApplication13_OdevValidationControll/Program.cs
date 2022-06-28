var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
