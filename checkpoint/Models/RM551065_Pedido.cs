using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEF.Models
{
    [Table("RM551605_PEDIDO")]
    public class RM551605_Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPedido { get; set; }

        [Required]
        public DateTime dataPedido { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal valorTotal { get; set; }
    }
}
