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
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

//https://www.sitename.com/DataFromUserRoute/Index/5
//app.MapControllerRoute(
//name: "temporary",
//    pattern: "{controller=Home}/{action=Index}/{id?}/{itemone?}/{itemtwo?}");


//  /Home/index/5
//  /attribute/index


// /index/5/home
// /index/attribute
app.Run();
