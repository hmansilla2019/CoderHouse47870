using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class CuentaCorriente : Cuenta
    {
        public float Descubierto { get; set; }
        public string NroCuentaEspecial
        {
            get { return "CC: " + _nroCuentaEspecial; }
            set { _nroCuentaEspecial = value; }
        }

    }
}
