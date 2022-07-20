// Onde fica toda a configuração de tabelas e tabelas com
// ligação no banco de dados

using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Models;

namespace WebMvcMysql.Data
{
    public class Contexto : DbContext
    {

        // Construtor para classe
        public Contexto(DbContextOptions<Contexto> options)
            : base(options) // Passmos o options ara dentro da base

        // Dentro de Contexto() -> colocamos un DbOptions que para
        // quando referenciarmos o nosso contexto nossa "Startup",
        // vai passar nossa string de conexão
        { }

        // Em DbSet definimos quais tabelas o EntityFramework deve
        // gerenciar ou caso não exista que o mesmo crie ou altere

        public DbSet<Usuario> Usuario { get; set; }

    }
}



// Com o contexto "Pronto" em Program.cs faremos a criação da string de conexão

