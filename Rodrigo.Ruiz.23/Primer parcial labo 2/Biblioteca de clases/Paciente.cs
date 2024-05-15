using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Paciente : Persona
    {
        public string diagnostico;

        public Paciente(string nombre, string barrioResidensia, string apellido, DateTime nacimiento, string diagnostico)
                        :base(apellido,barrioResidensia,nacimiento,nombre)
        {
            this.diagnostico = diagnostico;
        }
        public string Diagnostico
        {
            get
            {
                return diagnostico;
            }
            set 
            {
                diagnostico = value; 
            }
        }

        protected internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {base.barrioResidencia}");
            sb.AppendLine($"Diagnóstico: {diagnostico}");
            
            return sb.ToString();
        }
    }

    



}
