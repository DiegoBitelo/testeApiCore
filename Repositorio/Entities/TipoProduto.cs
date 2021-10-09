using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class TipoProduto
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

    }
}
