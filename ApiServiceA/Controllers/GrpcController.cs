using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using GrpcServiceB;
namespace ApiServiceA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GrpcController : ControllerBase
    {
        [HttpGet("sayhello/{name}")]
        public async Task<IActionResult> SayHello(string name)
        {
            using var channel = GrpcChannel.ForAddress("http://localhost:5207"); // URL của Service B
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(new HelloRequest { Name = name });

            return Ok(reply.Message);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(User user)
        {
            using var channel = GrpcChannel.ForAddress("http://localhost:5207");
            var client = new UserService.UserServiceClient(channel);

            var response = await client.CreateUserAsync(user);

            return Ok(response);

        }
    }
}
