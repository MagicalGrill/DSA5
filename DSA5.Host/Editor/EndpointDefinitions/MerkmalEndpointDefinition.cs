using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class MerkmalEndpointDefinition : BaseEndpointDefinition<Merkmal>
{
    protected override string Prefix => "/editor/merkmale";
}