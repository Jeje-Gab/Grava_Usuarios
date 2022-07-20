using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<>

// ----- String de conexão ----- //
builder.Services.AddDbContext<Contexto>
    (options => options.UseMySql(
        "server=localhost;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;pwd=1234",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));
var app = builder.Build();

// Antes de se criar a DataBase criamos o nosso controller e as paginas/telas
// Para Criação da controller -> 
// Controllers -> Adicionar -> Controlador... -> Usamos "Controlador MVC
// com exibições, usando o Entity Framework" e customiza-se de acordo com
// a necessidade




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
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
