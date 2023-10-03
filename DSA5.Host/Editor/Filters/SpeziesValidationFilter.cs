using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.Filters;

public class SpeziesValidationFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var spezies = context.GetArgument<Spezies>(1);

        if (string.IsNullOrEmpty(spezies.Name))
        {
            return await Task.FromResult(Results.BadRequest("Spezies ungültig: Name fehlt"));
        }

        return await next(context);
    }
}