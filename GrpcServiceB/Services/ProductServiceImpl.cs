using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace GrpcServiceB.Services;

public class ProductServiceImpl : ProductService.ProductServiceBase
{
    // Mock data for the products
    private readonly List<Product> _products =
    [
        new Product { Id = 1, Name = "Laptop", Price = 99.99f },
        new Product { Id = 2, Name = "Smartphone", Price = 699.99f },
        new Product { Id = 3, Name = "Headphones", Price = 199.99f }
    ];

    public override Task<ProductReply> GetProducts(Empty request, ServerCallContext context)
    {
        var reply = new ProductReply();
        reply.Products.AddRange(_products);
        return Task.FromResult(reply);
    }
}