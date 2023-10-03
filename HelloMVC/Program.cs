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

app.MapControllerRoute(
    name: "rawr",
    pattern: "rawr",defaults: new {controller = "User", action = "login" } );//takes them when they do /rawr to the user login page be//becareful because it could override the other one since it more specific

app.MapControllerRoute(
    name: "default",
    //default to home if nothing in there / default to index if nothing else / optional ID
    //ex: product/productInfo/21232 id
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
