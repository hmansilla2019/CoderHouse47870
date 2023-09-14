using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ListaMayores
    {
        private List<Cliente> _clientesMayores;

        public ListaMayores()
        {
            _clientesMayores = new List<Cliente>(); 
        }

        public void InsertarEnLista(Cliente[] clientes)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                _clientesMayores.Add(new Cliente(clientes[i].Nombre, 
                                                clientes[i].Id,
                                                clientes[i].Direccion,
                                                clientes[i].Edad));
            }

        }

        public List<Cliente> GetListaMayores()
        {
            return _clientesMayores;
        }

        public bool Borrar(Cliente cliente)
        {
            if (!_clientesMayores.Contains(cliente))
            {
                return false;
            }
            return _clientesMayores.Remove(cliente);
        }

        public int Buscar(Cliente cliente)
        {
            return _clientesMayores.IndexOf(cliente);
        }

        public bool Modificar(Cliente actual, Cliente nuevo)
        {
            int posicion = Buscar(actual);
            if (posicion<0)
            {
                return false;
            }

            _clientesMayores[posicion] = nuevo;
            return true;
        }

        public void LimpiarLista()
        {
            _clientesMayores.Clear();   
        }

        private int CompararClientes(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.Id.CompareTo(cliente2.Id);  
        }

        public void Ordenar()
        {
            _clientesMayores.Sort(CompararClientes);
        }





    }
}
