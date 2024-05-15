using System.Text;

namespace Biblioteca_de_clases
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia = string.Empty;
        protected DateTime nacimiento;
        string nombre;


        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{apellido}, {nombre}";
            }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;        
        }

        public Persona(string apellido, string barrioResidencia, DateTime nacimiento, string nombre):this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

        protected internal abstract string FichaExtra();
        
        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD: {Edad}");
            sb.AppendLine($"BARRIO RESIDENCIA: {barrioResidencia}");

            return sb.ToString();

        }

    }
}
