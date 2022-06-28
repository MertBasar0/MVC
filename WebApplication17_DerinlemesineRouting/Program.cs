var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//static route kullan�m�
app.MapControllerRoute(
    name: "test",
    pattern: "test",
    defaults: new { controller = "Home", action = "Test" });

//dinamik route kullan�m�
app.MapControllerRoute(
    name: "Dinamik",
    pattern: "{controller=Dynamic}/{action=Detail}/{name}/{id}");


//NotFound Route Kullan�m�
app.MapControllerRoute(
    name: "notfound",
    pattern: "{*url}",
    defaults:  new { controller = "Home", action = "NotFoundAction" });

app.Run();
