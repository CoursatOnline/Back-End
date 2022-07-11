using Microsoft.EntityFrameworkCore;
using EFCore.CheckConstraints;
using CoursatOnline.Data;
using CoursatOnline.Models;
using CoursatOnline.Repositories;

/* API and web clients will share data through this variable */
string txt = "";

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(n=>n.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddDbContext<CoursatOnlineDbContext>(n => n
                .UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("CoursatOnlineConn"))
                .UseDiscriminatorCheckConstraints()
                .UseEnumCheckConstraints());
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Category>, CategoryRepository>();
builder.Services.AddScoped<IRepository<Admin>, AdminRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Admin>, AdminRepository>();
builder.Services.AddScoped<IRepository<Instructor>, InstructorRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Instructor>, InstructorRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Registering CORS service */
builder.Services.AddCors(options =>
{
    options.AddPolicy(txt,
    builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
/* Using CORS */
app.UseCors(txt);

app.MapControllers();

app.Run();
