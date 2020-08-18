using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class ListaVendedor
    {
        static List<Vendedor> vendedores = new List<Vendedor>();

        public static List<Vendedor> GetVendedores()
        {
            return vendedores;
        }

        public static void SetVendedores(Vendedor c)
        {
            vendedores.Add(c);
        }
        public static void ListaDeVendedor()
        {
            vendedores.ForEach(cli => Console.WriteLine(cli));
        }
    }
}
