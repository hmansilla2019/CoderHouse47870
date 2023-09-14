using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Cliente
    {

        public string Nombre { get; set; }
        public long Id { get; set; }
        public string Direccion { get; set; }
        public short Edad { get; set; }


        public Cliente(string nombre, long id, string direccion, short edad)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Direccion = direccion;
            this.Edad = edad;
        }

        public override bool Equals(object? obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.Id.Equals(cliente.Id);    
        }


    }
}
