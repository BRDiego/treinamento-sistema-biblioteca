using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Model
{
    internal class ItemVenda
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        public decimal ValorMomento { get; set; }
    }
}
