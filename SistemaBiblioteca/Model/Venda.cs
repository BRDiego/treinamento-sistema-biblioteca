using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Model
{
    internal class Venda
    {
        public int Id { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public decimal ValorTotalPago { get; set; }
        public string NomeComprador { get; set; }
        public string NumeroDocumentoComprador { get; set; }
        public List<ItemVenda> Itens { get; set; };
    }
}
