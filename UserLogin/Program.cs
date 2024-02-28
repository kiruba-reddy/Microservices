using Microsoft.EntityFrameworkCore;
using UserLogin.Data;
using UserLogin.IRepository;
using UserLogin.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var ConStr = builder.Configuration.GetConnectionString("AppDbConnectionString");
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(ConStr,ServerVersion.AutoDetect(ConStr)));
builder.Services.AddControllers();
builder.Services.AddScoped<IAuthService,AuthService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapControllers());
app.Run();
