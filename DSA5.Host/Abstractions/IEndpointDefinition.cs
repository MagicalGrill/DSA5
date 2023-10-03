namespace DSA5.Host.Abstractions;

public interface IEndpointDefinition
{
    void RegisterEndpoints(WebApplication app);
}