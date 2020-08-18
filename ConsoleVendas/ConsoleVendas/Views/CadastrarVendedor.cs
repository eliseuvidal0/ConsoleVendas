using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;
using ConsoleVendas.Utility;
using ConsoleVendas.DAO;

namespace ConsoleVendas.Views
{
    class CadastrarVendedor
    {
        public static void Cadastrar()
        {
            Vendedor v = new Vendedor();

            Console.WriteLine("Informe o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do vendedor: ");
            v.Cpf = Console.ReadLine();

            if (BuscarVendedor(v.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro vendedor com um cpf já cadastrado\n");
            }
            else if (!CpfValidacao.ValidarCpf(v.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }
            else
            {
                ListaVendedor.SetVendedores(v) ;
                Console.WriteLine("\nVendedor Cadastrado!\n");
            }
        }
        private static Boolean BuscarVendedor(string cpf)
        {
            for (int i = 0; i < ListaVendedor.GetVendedores().Count; i++)
            {
                if (cpf == ListaVendedor.GetVendedores()[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
