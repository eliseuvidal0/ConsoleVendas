using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;
using ConsoleVendas.DAO;

namespace ConsoleVendas.Views
{
    class Program
    {

        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("--PROJETO DE VENDAS NO CONSOLE--\n");
                Console.WriteLine("\n1 – Cadastrar Cliente " +
                   "               \n2 – Listar Clientes" +
                   "               \n3 – Cadastrar Vendedor" +
                   "               \n4 – Listar Vendedores " +
                   "               \n5 – Cadastrar Produto " +
                   "               \n6 – Listar Produtos" +
                   "               \n7 – Registrar Venda " +
                   "               \n8 – Listar Vendas" +
                   "               \n9 – Listar Vendas por Cliente" +
                   "               \n0 – Sair");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("--CADASTRAR CLIENTE--");
                        CadastrarCliente.Cadastrar();
                        break;
                    case 2:
                        Console.WriteLine("--CLIENTES CADASTRADOS--\n");
                        ListaCliente.ListaDeCliente();
                        break;
                    case 3:
                        Console.WriteLine("--CADASTRO DE VENDEDORES--");
                        CadastrarVendedor.Cadastrar();
                        break;
                    case 4:
                        Console.WriteLine("--VENDEDORES CADASTRADOS--");
                        ListaVendedor.ListaDeVendedor();
                        break;
                    case 5:
                        Console.WriteLine("--CADASTRAR PRODUTO--");
                        CadastrarProduto.Cadastrar();
                        break;
                    case 6:
                        Console.WriteLine("--PRODUTOS CADASTRADOS--");
                        ListaProduto.ListaDeProduto();
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
  
        private static void Vender()
        {
            Console.WriteLine("Bem vindo a area de vendas!");
        }
        private static void ListarVenda()
        {
            Console.WriteLine("Bem vindo a listagem de vendas!");
        }
        private static void VendaCliente()
        {
            Console.WriteLine("Bem vindo a listagem de vendas por cliente!");
        }
    }
}
