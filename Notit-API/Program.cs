using Microsoft.EntityFrameworkCore;
using Notit.API.Controllers;
using Notit.API.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NotitContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContextSQLite")));

builder.Services.AddControllers();

builder.Services.AddScoped<CommentController>();
builder.Services.AddScoped<ThreadController>();

var app = builder.Build();

app.MapControllers();

app.Run();
