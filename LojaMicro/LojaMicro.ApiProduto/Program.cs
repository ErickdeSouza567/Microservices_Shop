using System.Text.Json.Serialization;
using LojaMicro.ApiProduto.Context;
using LojaMicro.ApiProduto.Repositories;
using LojaMicro.ApiProduto.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(X =>
X.JsonSerializerOptions.ReferenceHandler = 
ReferenceHandler.IgnoreCycles);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
        ));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); /*  Isso faz com que o AutoMapper procure automaticamente todas as configurações 
                                                                            *  de mapeamento (os "perfils") que você criou. Ele vai procurar por todos os 
                                                                          *  arquivos do seu código onde você definiu como um tipo de dado (como Cliente) pode 
                                                                          *  ser transformado em outro (como ClienteDTO).*/

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

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
