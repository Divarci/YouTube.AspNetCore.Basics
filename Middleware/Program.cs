using Middleware;

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

//app.UseMiddleware<CustomMiddleware>();



//app.Use(async (context, next) =>
//{
//    Console.WriteLine("method 1");

//    await next();

//    Console.WriteLine("method 2");
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("App will stop here");
//});


//app.Use(async (context, next) =>
//{
//    Console.WriteLine("method 1");

//    await next();

//    Console.WriteLine("method 2");
//});
//app.Use(async (context, next) =>
//{
//    Console.WriteLine("method 1");

//    await next();

//    Console.WriteLine("method 2");
//});

//app.Map("test-app", async context =>
//{
//    await context.Response.WriteAsync("Test-app endoint is initialized");
//});

app.MapWhen(x => x.Request.Method == "GET", builder =>
{
    builder.Use(async (context, next) =>
    {
        Console.WriteLine("method 1 from Get protocol");

        await next.Invoke();

        Console.WriteLine("method 2 from get protocol");
    });
});

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




app.Run();
