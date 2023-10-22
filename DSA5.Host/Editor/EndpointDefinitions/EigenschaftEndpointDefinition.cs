using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class EigenschaftEndpointDefinition : BaseEndpointDefinition<Eigenschaft>
{
    protected override string Prefix => "/editor/eigenschaften";
}