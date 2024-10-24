var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
//Add this line to enable serving static files
app.UseStaticFiles();

app.Run();
