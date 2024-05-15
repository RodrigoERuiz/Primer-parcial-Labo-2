using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    internal class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        Paciente Paciente
        {
            get 
            { 
                return paciente;
            }
        }

        public override string ToString()
        {
            return $"{fecha} se ha atendido a {paciente.NombreCompleto}";
        }




    }
}
