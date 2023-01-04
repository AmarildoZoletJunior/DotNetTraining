using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    [Table("TB_USUARIOS")]
    public class Usuario
    {

        /*
         * Schema:
         * [Table] Definir nome da tabela
         * [Column] Definir o nome da coluna
         * [NotMapped] Não mapear uma propriedade
         * [ForeignKey] Defini que a propriedade é o vinculo da chave estrangeira
         * [InversePropert] Define a referencia para cada FK  vinda da mesma tabela
         * [DatabaseGenerated] Posso definir se o banco pode gerenciar ou não uma propriedade, o id é controlado pelo banco sendo autoincrementável,
         * O número de cadastro do usuário pode ser autoincrementável.
         * 
         * DataAnootations:
         * [Key] Serve para definir que uma propriedade é uma PK(primaryKey)
         * 
         * EF Core:
         * [Index] Serve para definir/criar um indice no banco.
         * 
         * 
         * 
         */

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public int Id { get; set; }

        /*
        [Key]
        [Column("COD")]
        public int Codigo { get; set; }
        */

        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }

        [NotMapped]
        public bool RegistroAtivo { get; set; }
        public string? SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? ListaEnderecos { get; set; }
        public ICollection<Departamento>? ListaDepartamentos { get; set; }

    }
}
