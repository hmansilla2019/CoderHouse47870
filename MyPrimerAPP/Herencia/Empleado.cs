using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Empleado : Persona
    {
        protected string legajo;

        public Empleado(string legajo,long dni, string nombre, string domicilio) : base(dni, nombre, domicilio)
        {
            this.legajo = legajo;
        }

        public override void MostrarDatos()
        {
           //  base.MostrarDatos();
            Console.WriteLine("Legajo: " + this.legajo);

        }
    }
}
