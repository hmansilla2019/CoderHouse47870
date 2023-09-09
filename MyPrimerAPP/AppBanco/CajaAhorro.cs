using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class CajaAhorro : Cuenta
    {
        public string NroCuentaEspecial
        {
            get { return "CA: " +_nroCuentaEspecial;}
            set { _nroCuentaEspecial = value; }
        }


    }
}
