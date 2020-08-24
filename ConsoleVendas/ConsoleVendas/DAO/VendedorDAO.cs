using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static List<Vendedor> GetVendedores()
        {
            return vendedores;
        }

        public static void Salvar(Vendedor v)
        {
            if (BuscarVendedor(v.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro vendedor com um cpf já cadastrado\n");
            }

            vendedores.Add(v);
            Console.WriteLine("\nVendedor Cadastrado!\n");
        }
        public static void ListaDeVendedor()
        {
            Console.WriteLine("--VENDEDORES CADASTRADOS--");
            vendedores.ForEach(cli => Console.WriteLine(cli));
        }
        private static Boolean BuscarVendedor(string cpf)
        {
            for (int i = 0; i < GetVendedores().Count; i++)
            {
                if (cpf == GetVendedores()[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
