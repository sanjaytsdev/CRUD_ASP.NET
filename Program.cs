using Microsoft.EntityFrameworkCore;
using restapi.Repository;
using restapi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StudentRepo>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<StudentService>(); 

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin() 
                   .AllowAnyMethod()  
                   .AllowAnyHeader(); 
        });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();



app.Run();
