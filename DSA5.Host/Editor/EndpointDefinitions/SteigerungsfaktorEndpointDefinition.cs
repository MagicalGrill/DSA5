using DSA5.Entities.Meta;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class SteigerungsfaktorEndpointDefinition : BaseEndpointDefinition<Steigerungsfaktor>
{
    protected override string Prefix => "/editor/steigerungsfaktoren";
}