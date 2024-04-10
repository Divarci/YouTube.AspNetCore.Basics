using NewProject.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.Add(new ServiceDescriptor(typeof(SelectBicycle), new SelectBicycle())); // singleton
//builder.Services.Add(new ServiceDescriptor(typeof(SelectBus), new SelectBus()));// singleton
//builder.Services.Add(new ServiceDescriptor(typeof(MakeHoliday), new MakeHoliday(new SelectBicycle())));// singleton

//builder.Services.AddSingleton<SelectBicycle>(); //=> create one object of bicyle 

//builder.Services.AddScoped<SelectBicycle>(); //=> create objects for every request type

//builder.Services.AddTransient<SelectBicycle>(); //=>create objects for every single request

//builder.Services.AddScoped<MakeHoliday>(p=> new MakeHoliday(new SelectBicycle()));


builder.Services.AddTransient<IVehicle,SelectBicycle>();
builder.Services.AddScoped<MakeHoliday>();





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

app.Run();
