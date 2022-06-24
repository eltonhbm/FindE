using Blazored.Toast;
using FindE.Data;
using FindE.Features.Cep.Services;
using FindE.Features.Conta.Services;
using FindE.Features.Educador.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazoredToast();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data Source = FindE.db"));
builder.Services.AddSingleton<CepService>();
builder.Services.AddScoped<ContaService>();
builder.Services.AddScoped<EducadorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
