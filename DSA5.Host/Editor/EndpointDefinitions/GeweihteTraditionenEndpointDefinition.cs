using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class GeweihteTraditionenEndpointDefinition : BaseEndpointDefinition<Geweihtentradition>
{
    protected override string Prefix => "/editor/geweihtentraditionen";
}