using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public class SpeziesEndpointDefinition : BaseEndpointDefinition<Spezies>
{
    protected override string Prefix => "/editor/spezies";
}