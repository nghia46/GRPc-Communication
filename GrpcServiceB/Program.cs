using GrpcServiceB.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<UserServiceImpl>();
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ProductServiceImpl>();
app.MapGet("/", () => "This is Service B");

app.Run();
