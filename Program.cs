//using AtasService;
using AtasServiceProd;
using EntidadesService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NotasFiscaisService;
using OcorrenciasService;
using OrdensFornecimentoService;
using PedidosService;
using ProdutosService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAta, AtaClient>();
builder.Services.AddScoped<IPedido, PedidoClient>();
builder.Services.AddScoped<IEntidade, EntidadeClient>();
builder.Services.AddScoped<IOcorrencia, OcorrenciaClient>();
builder.Services.AddScoped<IOrdemFornecimento, OrdemFornecimentoClient>();
builder.Services.AddScoped<IProdutos, ProdutosClient>();
builder.Services.AddScoped<INotaFiscalXml, NotaFiscalXmlClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

