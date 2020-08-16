using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleVendas
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Vendedor> vendedores = new List<Vendedor>();
        static List<Produto> produtos = new List<Produto>();

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
                        Cliente();
                        break;
                    case 2:
                        ListarCliente();
                        break;
                    case 3:
                        Vendedores();
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

            if (BuscarPorCpf(c.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro clinte com um cpf já cadastrado\n");
            }
            else if (!ValidarCpf(c.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }
            else
            {
                clientes.Add(c);
                Console.WriteLine("\nCliente Cadastrado!\n");
            }

        }
        public static void ListarCliente()
        {
            Console.WriteLine("--Clientes Cadastrados--\n");

            clientes.ForEach(cli => Console.WriteLine(cli));

        }
        public static void Vendedores()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("--CADASTRO DE VENDEDORES--");

            Console.WriteLine("Informe o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf do vendedor: ");
            v.Cpf = Console.ReadLine();

            if (BuscarVendedor(v.Cpf))
            {
                Console.WriteLine("\n***Cpf já está cadastrado!***\n Não é possível cadastrar outro vendedor com um cpf já cadastrado\n");
            }
            else if (!ValidarCpf(v.Cpf))
            {
                Console.WriteLine("\n**CPF INVÁLIDO!**\n");
            }
            else
            {
                vendedores.Add(v);
                Console.WriteLine("\nVendedor Cadastrado!\n");
            }

        }
        public static void ListarVendedor()
        {
            Console.WriteLine("--VENDEDORES CADASTRADOS--");

            vendedores.ForEach(v => Console.WriteLine(v));
        }
        public static void Produto()
        {
            Produto p = new Produto();

            Console.WriteLine("--CADASTRAR PRODUTO--");

            Console.WriteLine("Indorme o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            p.preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe  a Quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (BuscarProduto(p.Nome))
            {
                Console.WriteLine("--PRODUTO JÁ ESTÁ CADASTRADO--\n**Não é possível cadastrar dois produtos com o mesmo nome**");
            } else
            {
                produtos.Add(p);
                Console.WriteLine("Produto Cadastrado!");
            }
        }
        public static void ListarProduto()
        {
            Console.WriteLine("--PRODUTOS CADASTRADOS--");

            produtos.ForEach(p => Console.WriteLine(p));
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
        public static Boolean BuscarPorCpf(string cpf)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (cpf == clientes[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }
        public static Boolean BuscarVendedor(string cpf)
        {
            for (int i = 0; i < vendedores.Count; i++)
            {
                if (cpf == vendedores[i].Cpf)
                {
                    return true;
                }
            }
            return false;
        }
        public static Boolean ValidarCpf(string cpf)
        {
            int total = CalculoCpf(cpf, 10);
            int validador = 1;

            if (!ValidarCodigo(cpf, validador, total))
            {
                return false;
            }

            total = CalculoCpf(cpf, 11);
            validador = 0;

            if (!ValidarCodigo(cpf, validador, total))
            {
                return false;
            }

            return true;
        }
        public static Boolean ValidarCodigo(string cpf, int validador, int total)
        {
            if (total % 11 < 2)
            {
                int cont = 10;
                foreach (char c in cpf)
                {
                    if (cont == validador)
                    {
                        if (Char.GetNumericValue(c) != 0)
                        { return false; }
                        break;
                    }
                    --cont;
                }
            }
            else
            {
                int resto = total % 11;
                int cont = 10;

                foreach (char c in cpf)
                {
                    if (cont == validador)
                    {
                        if (Char.GetNumericValue(c) != 11 - resto)
                        { return false; }
                        break;
                    }
                    --cont;
                }
            }
            return true;
        }
        public static int CalculoCpf(string cpf, int cont)
        {
            int total = 0;
            foreach (char c in cpf)
            {
                int numero = Convert.ToInt32(Char.GetNumericValue(c));
                total += (numero * cont);

                --cont;
                if (cont < 2)
                {
                    break;
                }
            }
            return total;
        }
        public static Boolean BuscarProduto(string nome)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                if (nome == produtos[i].Nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
