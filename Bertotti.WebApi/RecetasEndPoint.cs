using Bertotti.Domain;
using Bertotti.Services;

namespace Bertotti.WebApi;

public static class RecetaEndpoint
{
    public static void MapRecetaEndpoint(this WebApplication app)
    {
        var group = app.MapGroup("/api/recetas").WithTags("Recetas");

        // GET /api/recetas?estado=Emitida
        group.MapGet("/", async (string? estado, RecetaService service) =>
        {
            try { return Results.Ok(await service.GetByEstadoAsync(estado)); }
            catch (Exception ex) { return Results.BadRequest(ex.Message); }
        });

        // POST /api/recetas
        group.MapPost("/", async (Receta receta, RecetaService service) =>
        {
            try
            {
                var creada = await service.CreateAsync(receta);
                return Results.Created($"/api/recetas/{creada.Id}", creada);
            }
            catch (Exception ex) { return Results.BadRequest(ex.Message); }
        });

        // PUT /api/recetas/5/dispensar
        group.MapPut("/{id:int}/dispensar", async (int id, RecetaService service) =>
        {
            try
            {
                await service.DispensarAsync(id);
                return Results.NoContent();
            }
            catch (KeyNotFoundException ex) { return Results.NotFound(ex.Message); }
            catch (Exception ex) { return Results.BadRequest(ex.Message); }
        });

        // Opciones desde el backend
        group.MapGet("/estados", (RecetaService service) => Results.Ok(service.GetEstados()));
        group.MapGet("/coberturas", (RecetaService service) => Results.Ok(service.GetCoberturas()));
    }
}
