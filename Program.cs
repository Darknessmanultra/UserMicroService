using GestionUsuarios.Services;
using GestionUsuarios.Data;
using GestionUsuarios.Helpers;
using Microsoft.EntityFrameworkCore;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

builder.Services.AddMassTransit(x =>
{
    x.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("rabbitmq://localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });
        cfg.ReceiveEndpoint("user_queue", e =>
        {
            e.ConfigureConsumer<PasswordValidationConsumer>(context);
        });
        cfg.ReceiveEndpoint("password_queue", e =>
        {
            e.ConfigureConsumer<AuthConsumer>(context);
        });
    });

    x.AddRequestClient<PasswordValidationRequest>();
});

var app = builder.Build();
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure the HTTP request pipeline.
app.MapGrpcService<UserService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
