var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();  
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
