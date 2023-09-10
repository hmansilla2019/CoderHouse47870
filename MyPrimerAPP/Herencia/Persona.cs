using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;

        public Persona()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.domicilioParticular = string.Empty;
        }

        public Persona(long dni, string nombre, string domicilioParticular)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilioParticular;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("DNI: " + this.dni + " Nombre: " + this.nombre + " Domicilio: " + this.domicilioParticular);

        }



            

    }
}
