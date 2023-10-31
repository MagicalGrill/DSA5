using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class AspektEndpointDefinition : BaseEndpointDefinition<Aspekt>
{
    protected override string Prefix => "editor/aspekte";
}