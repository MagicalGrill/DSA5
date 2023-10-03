using MediatR;

namespace DSA5.Application.Editor.BaseEntities.Rassen.Commands;

public sealed class DeleteSpezies : IRequest
{
    public Guid Id { get; set; }
}