using Microsoft.EntityFrameworkCore;
using EFCore.CheckConstraints;
using CoursatOnline.Data;
using CoursatOnline.Models;
using CoursatOnline.Repositories;
using CoursatOnline.helpers;
using Microsoft.AspNetCore.Identity;
using CoursatOnline.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.FileProviders;

/* API and web clients will share data through this variable */
string txt = "";

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
// ///////////////////////////////

// Add services to the container.
builder.Services.Configure<JWT>(builder.Configuration.GetSection("JWT"));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<CoursatOnlineDbContext>();//**
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddDbContext<CoursatOnlineDbContext>(n => n
                .UseSqlServer(builder.Configuration.GetConnectionString("CoursatOnlineConn"))
                .UseDiscriminatorCheckConstraints()
                .UseEnumCheckConstraints());

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(o =>
    {
        o.RequireHttpsMetadata = false;
        o.SaveToken = false;
        o.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            ValidAudience = builder.Configuration["JWT:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
            ClockSkew = TimeSpan.Zero
        };
    });
// ///////////////////////

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
builder.Services.AddScoped<IRepositoryGetByName<Instructor>,InstructorRepository>();
builder.Services.AddScoped<IRepository<Comment>, CommentRepository>();
builder.Services.AddScoped<IRepository<Rating>, RatingRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Instructor>, InstructorRepository>();
builder.Services.AddScoped<IRepository<Course>, CourseRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Course>, CourseRepository>();
builder.Services.AddScoped<IRepository<Chapter>, ChapterRepository>();
builder.Services.AddScoped<IRepositoryGetByName<Chapter>, ChapterRepository>();
builder.Services.AddScoped<IRepository<Cart>, CartRepository>();
builder.Services.AddScoped<IRepository<CategoriesCourses>, CategoriesCoursesRepository>();
builder.Services.AddScoped<IRepository<CartItem>, CartItemRepository>();

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
builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

/* Using CORS */
app.UseCors(txt);
app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
    RequestPath = new PathString("/Resources")
});

app.MapControllers();

app.Run();
