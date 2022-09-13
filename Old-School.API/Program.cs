
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Old_School.Core.Services;
using Old_School.Core.Services.ServicesInterface;
using Old_School.Data.Data;
//using Old_School.Data.Data.Repositories;
//using Old_School.Data.Data.Repositories.SchoolEntity;
//using Old_School.Data.Data.Repositories.StudentEntity;
//using Old_School.Data.Data.Repositories.TeacherEntity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//builder.Services.AddScoped<IStudentRepo, StudentRepo>();
//builder.Services.AddScoped<ITeacherRepo, TeacherRepo>();
//builder.Services.AddScoped<ISchoolRepo, SchoolRepo>();
//builder.Services.AddScoped<ISchoolService, SchoolService>();
//builder.Services.AddScoped<IStudentService, StudentService>();
//builder.Services.AddScoped<ITeacherService, TeacherService>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
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

app.MapControllers();

app.Run();
