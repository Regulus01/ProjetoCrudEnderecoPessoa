using System.Reflection;
using AutoMapper;
using CrudPessoaEndereco.PessoaAPI.Config;
using CrudPessoaEndereco.PessoaAPI.Model.Context;
using CrudPessoaEndereco.PessoaAPI.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//MysqlConnection

var connection = builder.Configuration["MySqlConnection:MySQlConnectionString"];

builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql
    (connection, new MySqlServerVersion(new Version(8, 0))));

//Mapper config
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Invers�o de dependencia
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "CrudPessoaEndereco",
        Description = "Api para estudos"
        
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
