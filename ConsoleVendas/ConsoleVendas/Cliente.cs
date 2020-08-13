using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConcole
{
    class Cliente
    {
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf}";
        }
    }

    
}
