var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();

//using https
app.UseHttpsRedirection();

//using to acess the folder wwwroot, there you can store your files js
app.UseStaticFiles();
//create personalized routes
app.UseRouting();
//find automatic the routes
app.MapRazorPages();

app.Run();
