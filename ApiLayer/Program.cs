using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IExerciseService,ExerciseManager>();
builder.Services.AddScoped<IExerciseDal,EfExerciseDal>();

builder.Services.AddScoped<IReadyTrainingInformService,ReadyTrainingInformManager>();
builder.Services.AddScoped<IReadyTrainingInformDal,EfReadyTrainingInformDal>();

builder.Services.AddScoped<IReadyTrainingService, ReadyTrainingManager>();
builder.Services.AddScoped<IReadyTrainingDal, EfReadyTrainingDal>();


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
