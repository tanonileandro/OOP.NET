using Exercise01.Services.Implementations;
using Exercise01.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Swagger/OpenAPI configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPersonService, PersonService>();

var app = builder.Build();

// Enable Swagger for both Development and Production (optional)
app.UseSwagger();
app.UseSwaggerUI();

// Configure middleware
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
