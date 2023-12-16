using Microsoft.EntityFrameworkCore;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.Application.Services;
using SalesLinkPRO.Infra.Data;
using SalesLinkPRO.Infra.Data.Interfaces;
using SalesLinkPRO.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddScoped<IClienteAppService, ClienteAppService>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IProdutoAppService, ProdutoAppService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

builder.Services.AddScoped<IVendaAppService, VendaAppService>();
builder.Services.AddScoped<IVendaRepository, VendaRepository>();

builder.Services.AddScoped<IPagamentoAppService, PagamentoAppService>();
builder.Services.AddScoped<IPagamentoRepository, PagamentoRepository>();

builder.Services.AddScoped<ICompraAppService, CompraAppService>();
builder.Services.AddScoped<ICompraRepository, CompraRepository>();

builder.Services.AddScoped<IConsultorAppService, ConsultorAppService>();
builder.Services.AddScoped<IConsultorRepository, ConsultorRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
