using Routing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<RouteOptions>(options => options.ConstraintMap.Add("custom", typeof(CustomConstraint)));

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

app.UseRouting(); // user => chrome => addressbarr=> www.somewebsite.com/Personel/getallpersonels

app.UseAuthorization();

//action-controler = {action} - {controller} => match automaticly with our controlelrs and actions
//other patameters wont be match anyhing in ypur app like id


//app.MapControllerRoute(
//    name: "default",
//    pattern: "test",
//    new {controller = "Home",action="index" });

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id:int:max(5)}/{x:maxlength(5)}/{k:custom}/{z?}"
//    );

//app.MapControllerRoute(
//    name: "default",    
//    pattern: "{action=Index}/somestaticpage/{controller=Home}/{id?}");


//app.MapDefaultControllerRoute();

app.MapControllers();

//www.somesite.com/ => default parametrrs will be initialized
//www.somesite.com/Home =default action paramete will be initialized

app.Run();
