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
            Console.WriteLine("--CADASTRAR CLIENTE--");

            Console.WriteLine("Informe o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do cliiente: ");
            c.Cpf = Console.ReadLine();

            if (!CpfValidacao.ValidarCpf(c.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }

            ClienteDAO.Salvar(c);
        }
        
    }
}
