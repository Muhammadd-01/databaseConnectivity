using datbase_connectivity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Myclass>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("myconnection")));
var app = builder.Build();


app.Run();
