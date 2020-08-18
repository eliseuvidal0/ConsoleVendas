using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class ListaProduto
    {
        static List<Produto> produtos = new List<Produto>();
        public static List<Produto> GetProdutos()
        {
            return produtos;
        }

        public static void SetProdutos(Produto c)
        {
            produtos.Add(c);
        }
        public static void ListaDeProduto()
        {
            produtos.ForEach(cli => Console.WriteLine(cli));
        }
    }
}
