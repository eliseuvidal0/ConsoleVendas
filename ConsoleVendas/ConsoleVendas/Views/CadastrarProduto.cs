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
            Console.WriteLine("--CADASTRAR PRODUTO--");
            Produto p = new Produto();

            Console.WriteLine("Indorme o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            p.preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe  a Quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            ProdutoDAO.Salvar(p);
                
        }
        
    }
}
