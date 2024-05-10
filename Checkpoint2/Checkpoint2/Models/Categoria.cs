using System.ComponentModel.DataAnnotations.Schema;

namespace Checkpoint2.Models
{
    //criaçao da classe categoria da receita

    [Table("tb_Categoria")]
    public class Categoria
    {
        
        //propriedades da classe
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Descricao { get; set; }  

    }
}
