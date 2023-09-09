using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Estudiante : Persona
    {
        protected string carrera;
        public Estudiante(string carrera, long dni, string nombre, string domicilio) : base(dni, nombre, domicilio)
        {
            this.carrera = carrera;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Carrera: " + this.carrera);

        }
    }
}
