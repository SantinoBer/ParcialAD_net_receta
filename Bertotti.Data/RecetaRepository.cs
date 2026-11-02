using Bertotti.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bertotti.Data
{
    public class RecetaRepository
    {
        private readonly RecetaContext context;
        public RecetaRepository(RecetaContext context)
        {
            this.context = context;
        }
        public async Task AddAsync (Receta receta)
        {
            context.Recetas.Add(receta);
            await context.SaveChangesAsync();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var receta = await context.Recetas.FindAsync(id);
            if (receta != null)
            {
                context.Remove(receta);
                await context.SaveChangesAsync();
            }
            return false;
        }
        public async Task<Receta?> GetByIdAsync(int id)
        {
            return await context.Recetas
                    .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<List<Receta>> GetByEstadoAsync(string? estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
            {
                return await context.Recetas.ToListAsync();
            }
            return await context.Recetas
                .Where(r => r.Estado == estado)
                .ToListAsync();

        }
        public async Task UpdateAsync(Receta receta)
        {
            context.Recetas.Update(receta);
            await context.SaveChangesAsync();
        }
    }
}
