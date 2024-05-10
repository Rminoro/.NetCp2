using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Checkpoint2.Models
{
    [Table("tb_receita")]
    public class Receita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Ingredientes é obrigatório.")]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "O campo Modo de Preparo é obrigatório.")]
        public string ModoPreparo { get; set; }
    }
}
