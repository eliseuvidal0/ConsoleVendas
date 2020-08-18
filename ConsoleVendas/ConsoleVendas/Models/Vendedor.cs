using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleVendas.Models
{
    class Vendedor
    {
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }
        public string Nome { get; set; }
        public  string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf}";
        }
    }
}
