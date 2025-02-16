var builder = WebApplication.CreateBuilder(args);

// Agregar servicios
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar Kestrel para escuchar en todas las interfaces
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // Escuchar en el puerto 80 dentro del contenedor
});

var app = builder.Build();

app.MapGet("/", () => "¡Hola desde C# API!");

app.Run();
