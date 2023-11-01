using DSA5.Entities.Welt;

namespace DSA5.Host.Editor.EndpointDefinitions;

public sealed class TalentgruppeEndpointDefinition : BaseEndpointDefinition<Talentgruppe>
{
    protected override string Prefix => "/editor/talentgruppen";
}