using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEF.Models
{
    [Table("RM551605_FORNECEDOR")]
    public class RM551605_Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFornecedor { get; set; }

        [Required]
        [MaxLength(9)] // Exemplo: "01000-000"
        public string nrCEP { get; set; }

        [Required]
        [MaxLength(200)]
        public string dsEndereco { get; set; }

        [Required]
        [MaxLength(2)] // Exemplo: SP, RJ
        public string Estado { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }
    }
}
