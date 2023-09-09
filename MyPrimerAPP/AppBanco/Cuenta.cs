using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    public class Cuenta
    {
        public Cuenta()
        {
            this._nroCuenta = 0;
            this.Saldo = 0;
            this.FechaApertura = DateTime.Now;
            this.Saldo = 0;
        }

        public Cuenta(int nrocuenta, float saldo, DateTime fechaAoertura, string tipoInteres)
        {
            this._nroCuenta = nrocuenta;
            this.Saldo = saldo;
            this.FechaApertura = fechaAoertura;
            this.TipoInteres = tipoInteres;
        }

        protected string _nroCuentaEspecial;

        private int _nroCuenta;

        public int NroCuenta
        {
            get {
                return _nroCuenta;
            }
            set { 
                _nroCuenta = value; 
            }
        }  

        public DateTime FechaApertura { get; set; }

        public float Saldo { get; set; }

        public string TipoInteres { get; set; }

        public Cliente cliente { get; set; }


        public void Depositar(float importeDeposito)
        {
            this.Saldo+=importeDeposito;
        }

        public void Extraer(float importeExtraccion)
        {
            this.Saldo -= importeExtraccion;
        }

        public float CalcularTasa(string tipoInteres)
        {
            if (tipoInteres == "Variable")
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }


    }
}
