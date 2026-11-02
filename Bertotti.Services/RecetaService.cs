using Bertotti.Data;
using Bertotti.Domain;

namespace Bertotti.Services
{
    public class RecetaService
    {
        private readonly RecetaRepository repository;
        public RecetaService(RecetaRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<Receta>> GetByEstadoAsync(string estado)
        {
            if (!string.IsNullOrWhiteSpace(estado) && !Estados.Todos.Contains(estado))
            {
                throw new Exception("El estado no es valido");
            }
            return await repository.GetByEstadoAsync(estado);
        }
        public async Task<Receta> CreateAsync(Receta receta)
        {
            if (string.IsNullOrWhiteSpace(receta.DniPaciente))
            {
                throw new Exception("El dni es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(receta.Cobertura))
            {
                throw new Exception("La cobertura es obligatoria");
            }
            if (receta.Cantidad < 1 || receta.Cantidad > 5)
            {
                throw new Exception("La cantidad debe ser un entero entre 1 y 5");
            }
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            if (receta.FechaEmision != hoy && receta.FechaEmision != hoy.AddDays(-1))
            {
                throw new Exception("La fecha de emisión debe ser hoy o el día anterior");
            }
            receta.Id = 0;                       // lo genera la BD
            receta.Estado = Estados.Emitida;     // siempre "Emitida"
            await repository.AddAsync(receta);
            return receta;
        }
        public async Task DispensarAsync(int id)
        {
            var receta = await repository.GetByIdAsync(id);
            if (receta == null) 
            {
                throw new KeyNotFoundException($"No existe la receta {id}.");
            }
            if (receta.Estado == Estados.Dispensada)
                throw new Exception("La receta ya fue dispensada.");

            receta.Estado = Estados.Dispensada;
            await repository.UpdateAsync(receta);
        }

        public IEnumerable<string> GetEstados() => Estados.Todos;
        public IEnumerable<string> GetCoberturas() => Coberturas.Todas;
    }
}
