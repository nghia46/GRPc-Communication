using Grpc.Core;

namespace GrpcServiceB.Services;

public class UserServiceImpl : UserService.UserServiceBase
{
    public override Task<User> CreateUser(User request, ServerCallContext context)
    {
        // Giả sử bạn lưu User vào cơ sở dữ liệu hoặc xử lý logic nào đó ở đây
        User user = new User{
            Email = request.Email,
            Name = request.Name,
            Id = request.Id
        };

        return Task.FromResult(user);
    }
}