using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEF.Models
{
    [Table("RM551605_PRODUTO")]
    public class RM551605_Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProduto { get; set; }

        [Required]
        [MaxLength(150)]
        public string nmProduto { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal preco { get; set; }
    }
}
