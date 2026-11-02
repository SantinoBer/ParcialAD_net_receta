namespace Bertotti.Domain
{
    public class Receta
    {
        public int Id { get; set; }
        public string DniPaciente { get; set; } = string.Empty;
        public DateOnly FechaEmision { get; set; }
        public int Cantidad { get; set; }
        public string Cobertura { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public Receta() { }

        public Receta(int id, string dniPaciente, DateOnly fechaEmision, int cantidad, string cobertura, string estado)
        {
            Id = id;
            DniPaciente = dniPaciente;
            FechaEmision = fechaEmision;
            SetCantidad(cantidad);
            Cobertura = cobertura;
            Estado = estado;
        }
        public void SetCantidad(int cant)
        {
            if (cant > 0 && cant <= 5) 
            { 
                Cantidad = cant;
            }
            else
            {
                throw new ArgumentException("La cantidad debe ser entre 1 y 5", nameof(cant));
            }
        }
        public void SetFechaEmision(DateOnly fechaEmision)
        {
            if (fechaEmision.Day ==  DateTime.Today.Day || fechaEmision.Day >= (DateTime.Today.Day - 1))
            {
                FechaEmision = fechaEmision;
            }
            else
            {
                throw new ArgumentException("La cantidad debe ser entre ayer y hoy", nameof(fechaEmision));
            }
        }
    }
}
