using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class ListaCliente
    {

        static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> GetClientes() 
            {
            return clientes;
            }

        public static void SetClientes(Cliente c)
        {
            clientes.Add(c);
        }
        public static void ListaDeCliente()
        {
            clientes.ForEach(cli => Console.WriteLine(cli));
        }

        
    }
}
