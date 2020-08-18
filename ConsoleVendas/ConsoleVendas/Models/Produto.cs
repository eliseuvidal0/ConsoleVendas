using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleVendas.Models
{
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public double preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Produto: {Nome} | Preço: {preco} | Quantidade: {Quantidade}";
        }
    }
}
