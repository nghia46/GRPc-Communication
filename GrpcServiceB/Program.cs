using GrpcServiceB.Services;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpcSwagger();
builder.Services.AddGrpc();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "gRPC Server API", Version = "v1" });
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "gRPC Server API V1");
});
// Configure the HTTP request pipeline.
app.MapGrpcService<UserServiceImpl>();
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ProductServiceImpl>();
app.MapGet("/", () => "This is Service B");

app.Run();
