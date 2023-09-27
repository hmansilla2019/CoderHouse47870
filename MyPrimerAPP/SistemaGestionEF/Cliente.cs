using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEF
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreApellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }

    }
}
