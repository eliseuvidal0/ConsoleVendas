using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;
using ConsoleVendas.Utility;
using ConsoleVendas.DAO;

namespace ConsoleVendas.Views
{
    class CadastrarCliente
    {
        public static void Cadastrar()
        {
            Cliente c = new Cliente();

            Console.WriteLine("Informe o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do cliiente: ");
            c.Cpf = Console.ReadLine();

            if (BuscarPorCpf(c.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro clinte com um cpf já cadastrado\n");
            }
            else if (!CpfValidacao.ValidarCpf(c.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }
            else
            {
                ListaCliente.SetClientes(c);
                Console.WriteLine("\nCliente Cadastrado!\n");
            }
        }
        private static Boolean BuscarPorCpf(string cpf)
        {
            for (int i = 0; i < ListaCliente.GetClientes().Count; i++)
            {
                if (cpf == ListaCliente.GetClientes()[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
