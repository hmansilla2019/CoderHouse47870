using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosClases
{
    internal class Producto
    {
        // Atributos
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        // private string _categoria;


        public string Categoria { get; set; }

        public double GetPrecioCompra()
        {
            return _precioCompra;
        }
        public void SetPrecioCompra(double valor)
        {
            this._precioCompra = valor;
        }
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public Double PrecioVenta
        {
            get { return this._precioVenta; }
            set { this._precioVenta = value; }
        }
        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }



        // Constructores
        public Producto()
        {
            _codigo = 0;
            _descripcion = string.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            Categoria = String.Empty;
        }

        public Producto(int codigo, string descripcion, double precioCompra,double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            Categoria = categoria;
        }

        public bool HayPrecioDeVenta()
        {
            // Toda la logica
            return this._precioVenta > 0;
        }




    }
}
