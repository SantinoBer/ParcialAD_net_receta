using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bertotti.Domain
{
    public static class Estados
    {
        public const string Emitida = "Emitida";
        public const string Dispensada = "Dispensada";
        public static readonly string[] Todos = { Emitida, Dispensada };
    }

    public static class Coberturas
    {
        public const string ObraSocial = "Obra Social";
        public const string Prepaga = "Prepaga";
        public const string Particular = "Particular";
        public static readonly string[] Todas = { ObraSocial, Prepaga, Particular };
    }
}
