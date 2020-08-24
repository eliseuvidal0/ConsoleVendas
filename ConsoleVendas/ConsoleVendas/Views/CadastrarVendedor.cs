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
            Console.WriteLine("--CADASTRO DE VENDEDORES--");
            Vendedor v = new Vendedor();

            Console.WriteLine("Informe o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do vendedor: ");
            v.Cpf = Console.ReadLine();


            if (!CpfValidacao.ValidarCpf(v.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }

            VendedorDAO.Salvar(v);
        }
        
    }
}
