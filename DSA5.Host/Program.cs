using DSA5.Application;
using DSA5.Application.Editor.BaseEntities.Rassen.Commands;
using DSA5.Application.Editor.BaseEntities.Rassen.Queries;
using DSA5.Entities.Welt;
using DSA5.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World");
app.MapGet("/editor/spezies", async (IMediator mediator) =>
{
    var getAllSpezies = new GetAllSpezies();
    var spezies = await mediator.Send(getAllSpezies);
    return Results.Ok(spezies);
})
    .WithName("GetAllSpezies");

app.MapGet("/editor/spezies/{id:guid}", async (IMediator mediator, Guid id) =>
{
    var getSpezies = new GetSpeziesById() { Id = id };
    var spezies = await mediator.Send(getSpezies);
    return Results.Ok(spezies);
})
    .WithName("GetSpeziesById");

app.MapPost("/editor/spezies", async (IMediator mediator, [FromBody] Spezies spezies) =>
{
    var createSpezies = new CreateSpezies()
    {
        ApKosten = spezies.ApKosten,
        Beschreibung = spezies.Beschreibung,
        Geschwindigkeit = spezies.Geschwindigkeit,
        Lebenspunkte = spezies.Lebenspunkte,
        Name = spezies.Name,
        Seelenkraft = spezies.Seelenkraft,
        Zaehigkeit = spezies.Zaehigkeit
    };
    var createdSpezies = await mediator.Send(createSpezies);
    return Results.CreatedAtRoute("GetSpeziesById", new { createdSpezies.Id }, createdSpezies);
});

app.MapPut("/editor/spezies/{id:guid}", async (IMediator mediator, [FromBody] Spezies spezies, Guid id) =>
{
    var updateSpezies = new UpdateSpezies() { Id = id, UpdatedSpezies = spezies };
    var guid = await mediator.Send(updateSpezies);
    return Results.Ok(guid);
});

app.MapDelete("/editor/spezies/{id:guid}", async (IMediator mediator, Guid id) =>
{
    var deleteSpezies = new DeleteSpezies() { Id = id };
    await mediator.Send(deleteSpezies);
    return Results.NoContent();
});

app.Run();