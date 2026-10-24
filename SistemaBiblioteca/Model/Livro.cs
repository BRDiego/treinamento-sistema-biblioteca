using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Model
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoPublicacao { get; set; }
        public string NomeAutor { get; set; }
        public CategoriaLivro Categoria { get; set; }
    }
}
