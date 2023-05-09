using UsingApiCnpj.Interfaces;
using UsingApiCnpj.Mappings;
using UsingApiCnpj.Rest;
using UsingApiCnpj.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//SWAGGER LAYOUT: inicializando no swagger as interfaces
builder.Services.AddSingleton<ICnpjService, CnpjService>();
builder.Services.AddSingleton<IApiCnpj, ApiCnpjRest>();

builder.Services.AddAutoMapper(typeof(CnpjMapping));

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
