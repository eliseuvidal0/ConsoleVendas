using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class ClienteDAO
    {

        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> GetClientes() 
            {
            return clientes;
            }

        public static void Salvar(Cliente c)
        {
            if (BuscarPorCpf(c.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro clinte com um cpf já cadastrado\n");
            }

            clientes.Add(c);
            Console.WriteLine("\nCliente Cadastrado!\n");    
        }
        public static void ListaDeCliente()
        {
            Console.WriteLine("--CLIENTES CADASTRADOS--\n");
            clientes.ForEach(cli => Console.WriteLine(cli));
        }

        private static Boolean BuscarPorCpf(string cpf)
        {
            for (int i = 0; i < GetClientes().Count; i++)
            {
                if (cpf == GetClientes()[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
