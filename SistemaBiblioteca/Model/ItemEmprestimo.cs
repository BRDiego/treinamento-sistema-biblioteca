using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Model
{
    internal class ItemEmprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
    }
}
