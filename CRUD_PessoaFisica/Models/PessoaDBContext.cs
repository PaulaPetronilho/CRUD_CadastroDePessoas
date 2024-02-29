using CRUD_PessoaFisica.Models;
using System.Data.Entity;

public class PessoaDBContext : DbContext
{
    public DbSet<PessoaFisicaModel> Pessoa { get; set; }
}