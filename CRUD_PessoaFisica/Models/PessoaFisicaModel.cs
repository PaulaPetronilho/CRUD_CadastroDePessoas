using System;

namespace CRUD_PessoaFisica.Models
{
    public class PessoaFisicaModel
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string ValorRenda { get; set; }
        public string CPF { get; set; }
    }
}