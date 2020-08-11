using System;
using System.Collections.Generic;

namespace VendasConcole
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("\n1 – Cadastrar de Cliente " +
                   "               \n2 – Listar de Clientes" +
                   "               \n3 – Cadastrar de Vendedor" +
                   "               \n4 – Listar de Vendedores " +
                   "               \n5 – Cadastrar de Produto " +
                   "               \n6 – Listar de Produtos" +
                   "               \n7 – Registrar Venda " +
                   "               \n8 – Listar Vendas" +
                   "               \n9 – Listar Vendas por Cliente" +
                   "               \n0 – Sair");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Cliente();
                        break;
                    case 2:
                        ListarCliente();
                        break;
                    case 3:
                        Vendedor();
                        break;
                    case 4:
                        ListarVendedor();
                        break;
                    case 5:
                        Produto();
                        break;
                    case 6:
                        ListarProduto();
                        break;
                    case 7:
                        Vender();
                        break;
                    case 8:
                        ListarVenda();
                        break;
                    case 9:
                        VendaCliente();
                        break;
                    case 0:
                        Console.WriteLine("---TCHAAAU!!");
                        break;
                    default:
                        Console.WriteLine("---Opção inválida!");
                        break;
                }
                Console.WriteLine("-Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);
        }

        public static void Cliente()
        {
            Cliente c = new Cliente();
            Console.WriteLine("--Cadastrar Cliente--");
            Console.WriteLine("Informe o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do cliiente: ");
            c.Cpf = Console.ReadLine();
            clientes.Add(c);

        }
        public static void ListarCliente()
        {
            Console.WriteLine("--Clientes Cadastrados--");

            clientes.ForEach(cli => Console.WriteLine("Nome: " + cli.Nome + " Cpf: " + cli.Cpf));

        }
        public static void Vendedor()
        {
            Console.WriteLine("Bem vindo ao cadastro de vendedores!");
        }
        public static void ListarVendedor()
        {
            Console.WriteLine("Bem vindo ao Listar vendedor!");
        }
        public static void Produto()
        {
            Console.WriteLine("Bem vindo ao cadastro de produtos!");
        }
        public static void ListarProduto()
        {
            Console.WriteLine("Bem vindo ao cadastrolistar produtos!");
        }
        public static void Vender()
        {
            Console.WriteLine("Bem vindo a area de vendas!");
        }
        public static void ListarVenda()
        {
            Console.WriteLine("Bem vindo a listagem de vendas!");
        }
        public static void VendaCliente()
        {
            Console.WriteLine("Bem vindo a listagem de vendas por cliente!");
        }
    }
}
