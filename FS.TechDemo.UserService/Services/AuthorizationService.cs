using Grpc.Core;

namespace UserAuthorizationService.Services;

public class AuthorizationService : UserAuthorizationService.UserAuthorizationServiceBase

{
    private readonly ILogger<AuthorizationService> _logger;

    public AuthorizationService(ILogger<AuthorizationService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}