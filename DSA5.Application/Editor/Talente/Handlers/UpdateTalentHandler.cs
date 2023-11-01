using DSA5.Application.Common.Persistence;
using DSA5.Application.Editor.Base.Commands;
using DSA5.Application.Editor.Talente.Specs;
using DSA5.Entities.Welt;
using MediatR;

namespace DSA5.Application.Editor.Talente.Handlers;

public sealed class UpdateTalentHandler : IRequestHandler<BaseUpdateRequest<Talent>>
{
    private readonly IRepository<Talent> _repository;

    public UpdateTalentHandler(IRepository<Talent> repository)
    {
        _repository = repository;
    }

    public async Task Handle(BaseUpdateRequest<Talent> request, CancellationToken cancellationToken)
    {
        var talent =
            await _repository.FirstOrDefaultAsync(new TalentByIdCompleteSpec(request.Id), cancellationToken);
        if (talent is null) return;
        var item = request.Item;
        foreach (var anwendungsgebiet in item.Anwendungsgebiete) anwendungsgebiet.TalentId = talent.Id;

        talent.Name = item.Name;
        talent.Anwendungsgebiete = item.Anwendungsgebiete;
        talent.Beschreibung = item.Beschreibung?
            .Replace(Environment.NewLine, " ")
            .Replace("\n", " ")
            .Replace("\r", " ");
        talent.TalentgruppeId = item.TalentgruppeId;
        talent.SteigerungsfaktorId = item.SteigerungsfaktorId;
        talent.Wurf1Id = item.Wurf1Id;
        talent.Wurf2Id = item.Wurf2Id;
        talent.Wurf3Id = item.Wurf3Id;
        talent.BeeinflusstDurchBelastung = item.BeeinflusstDurchBelastung;
        talent.LastUpdated = DateTime.UtcNow;
        await _repository.UpdateAsync(talent, cancellationToken);
    }
}