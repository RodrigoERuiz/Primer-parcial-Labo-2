using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre,string barrioResidencia , DateTime nacimiento, string apellido, List<Consulta> consultas, bool esResidente)
                                :base(nombre,barrioResidencia,nacimiento,apellido)
        {
            this.consultas = consultas;
            this.esResidente = esResidente;
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)//revisar
        {
            Consulta consultaNueva = new Consulta(DateTime.Now,paciente);
            doctor.consultas.Append(consultaNueva);

            return consultaNueva;
        }

        protected internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            string mensajeResidencia = string.Empty;

            if (esResidente)
            {
                mensajeResidencia = "NO";
            }
            else
            {
                mensajeResidencia = "SI";
            }

            sb.AppendLine($"¿Finalizó residencia? {mensajeResidencia}");
            sb.AppendLine($"ATENCIONES:");

            foreach (Consulta atencion in consultas)
            {
                sb.AppendLine(atencion.ToString());
            }

            return sb.ToString();
        }
    }
}
