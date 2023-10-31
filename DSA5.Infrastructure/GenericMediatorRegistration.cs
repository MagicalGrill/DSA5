using System.Reflection;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Base.Handlers;
using DSA5.Application.Editor.Base.Queries;
using DSA5.Entities.Common.Contracts;
using DSA5.Shared.Collections;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DSA5.Infrastructure;

internal static class GenericMediatorRegistration
{
    public static IServiceCollection AddGenericMediatorServices(this IServiceCollection services)
    {
        var assembly = Assembly.GetAssembly(typeof(BaseEntity));
        var implementationAssembly = Assembly.GetAssembly(typeof(BaseCreateHandler<>));
        if (assembly is null || implementationAssembly is null) return services;
        var baseEntities = assembly.GetTypes()
            .Where(t => t.IsSubclassOf(typeof(BaseEntity)) && !t.IsAbstract).ToList();

        var methodInfos = typeof(GenericMediatorRegistration)
            .GetMethods(BindingFlags.Static | BindingFlags.NonPublic)
            .OrderBy(m => m.Name)
            .ToList();


        return services
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[0], typeof(BaseCreateHandler<>))
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[1], typeof(BaseDeleteHandler<>))
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[2], typeof(BaseGetAllHandler<>))
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[3], typeof(BaseGetByIdHandler<>))
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[4], typeof(BaseGetBySpecHandler<>))
            .RegisterHandlers(baseEntities, implementationAssembly, methodInfos[5], typeof(BaseUpdateHandler<>));
    }

    private static IServiceCollection RegisterHandlers(
        this IServiceCollection services,
        IEnumerable<Type> baseEntities,
        Assembly implementationAssembly,
        MethodInfo methodInfo,
        Type HandlerType
    )
    {
        var implementationTypes = implementationAssembly.GetTypes()
            .Where(t =>
                !t.IsInterface
                && !t.IsAbstract
                && t.IsSubclassOfRawGeneric(HandlerType));

        foreach (var entity in baseEntities.Where(entity => implementationTypes.None(t =>
                     t.BaseType?.GenericTypeArguments.Contains(entity) ?? false)))
        {
            var method = methodInfo.MakeGenericMethod(entity);
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

    private static IServiceCollection AddGetBySpecService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services
            .AddTransient<IRequestHandler<BaseGetBySpecRequest<T>, ICollection<T>>, BaseGetBySpecHandler<T>>();
    }

    private static IServiceCollection AddGetByIdService<T>(this IServiceCollection services) where T : BaseEntity
    {
        return services.AddTransient<IRequestHandler<BaseGetByIdRequest<T>, T?>, BaseGetByIdHandler<T>>();
    }

    private static bool IsSubclassOfRawGeneric(this Type? toCheck, Type generic)
    {
        if (toCheck == generic) return false;

        while (toCheck is not null && toCheck != typeof(object))
        {
            toCheck = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;

            if (toCheck == generic) return true;

            toCheck = toCheck.BaseType;
        }

        return false;
    }
}