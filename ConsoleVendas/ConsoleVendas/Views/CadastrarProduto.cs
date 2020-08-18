using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;
using ConsoleVendas.Utility;
using ConsoleVendas.DAO;

namespace ConsoleVendas.Views
{
    class CadastrarProduto
    {
        public static void Cadastrar()
        {
            Produto p = new Produto();

            Console.WriteLine("Indorme o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            p.preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe  a Quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (BuscarProduto(p.Nome))
            {
                Console.WriteLine("--PRODUTO JÁ ESTÁ CADASTRADO--\n**Não é possível cadastrar dois produtos com o mesmo nome**");
            }
            else
            {
                ListaProduto.SetProdutos(p);
                Console.WriteLine("Produto Cadastrado!");
            }
        }
        private static Boolean BuscarProduto(string nome)
        {
            for (int i = 0; i < ListaProduto.GetProdutos().Count; i++)
            {
                if (nome == ListaProduto.GetProdutos()[i].Nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
