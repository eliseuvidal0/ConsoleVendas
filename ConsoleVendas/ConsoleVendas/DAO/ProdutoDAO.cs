using System;
using System.Collections.Generic;
using System.Text;
using ConsoleVendas.Models;

namespace ConsoleVendas.DAO
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();
        public static List<Produto> GetProdutos()
        {
            return produtos;
        }

        public static void Salvar(Produto p)
        {
            if(BuscarProduto(p.Nome))
            {
                Console.WriteLine("--PRODUTO JÁ ESTÁ CADASTRADO--\n**Não é possível cadastrar dois produtos com o mesmo nome**");
            }
            
            produtos.Add(p);
            Console.WriteLine("Produto Cadastrado!");

        }
        public static void ListaDeProduto()
        {
            Console.WriteLine("--PRODUTOS CADASTRADOS--");
            produtos.ForEach(cli => Console.WriteLine(cli));
        }
        public static Boolean BuscarProduto(string nome)
        {
            for (int i = 0; i < ProdutoDAO.GetProdutos().Count; i++)
            {
                if (nome == ProdutoDAO.GetProdutos()[i].Nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
