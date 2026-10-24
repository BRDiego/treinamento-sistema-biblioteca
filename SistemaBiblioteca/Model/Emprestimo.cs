using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Model
{
    internal class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataHoraRetirada { get; set; }
        public DateTime DataHoraCombinadaDevolucao { get; set; }
        public DateTime DataHoraDevolucaoReal { get; set; }
        public string NomeCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string TelefoneCliente { get; set; }
    }
}
