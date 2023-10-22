using System.Reflection;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Base.Handlers;
using DSA5.Application.Editor.Base.Queries;
using DSA5.Entities.Common.Contracts;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure;

internal static class GenericMediatorRegistration
{
    public static IServiceCollection AddGenericMediatorServices(this IServiceCollection services)
    {
        var assembly = Assembly.GetAssembly(typeof(BaseEntity));
        if (assembly is null) return services;
        var baseEntities = assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(BaseEntity)) && !t.IsAbstract);

        var methodInfos = typeof(GenericMediatorRegistration).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

        foreach (var entityType in baseEntities)
        foreach (var methodInfo in methodInfos)
        {
            var method = methodInfo.MakeGenericMethod(entityType);
            method.Invoke(null, new object[] { services });
        }

        return services;
    }

    private static IServiceCollection AddCreateService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseCreateRequest<T>, T>, BaseCreateHandler<T>>();
    }

    private static IServiceCollection AddUpdateService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseUpdateRequest<T>>, BaseUpdateHandler<T>>();
    }

    private static IServiceCollection AddDeleteService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseDeleteRequest<T>>, BaseDeleteHandler<T>>();
    }

    private static IServiceCollection AddGetAllService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseGetAllRequest<T>, ICollection<T>>, BaseGetAllHandler<T>>();
    }

    private static IServiceCollection AddGetByIdService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseGetByIdRequest<T>, T?>, BaseGetByIdHandler<T>>();
    }
}