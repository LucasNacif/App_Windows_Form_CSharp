using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroMayoryMenor.modelos
{
    internal class Cliente
    {
        //private string nombre;
        //private string apellido;
        //private string telefono;
        //private string tarjetaDeCredito;
        //no hace falta crear las variables si lo haces asi -->
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }
        public string nombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}
