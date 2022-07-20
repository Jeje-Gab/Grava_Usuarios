using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvcMysql.Models
{
    [Table("Usuario")] // Pode utilizar p/ criar outro nome no banco
    public class Usuario
    {
        [Display(Name ="Código")] // Para aparecer na tela
        [Column("Id")] // Mesma função que o "[Table("Usuario")]"
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
    }
}

// Apos a tabela usuario estar "finalizada" partimos p/ criação do contexto
// Passo: 
// Cria uma pasta chamada Data "Como irma de Models e Controllers" ->
// e dentro de Data cria-se a pasta Contexto -> Onde ficará toda a
// configuração de tabela e tabelas que vão fazer coneçao com o bamco
// de dados
