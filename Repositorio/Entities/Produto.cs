using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
    public class Produto
    {

        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(200, ErrorMessage = "Nome permite o máximo 200 caracteres")]
        public string Nome { get; set; }

        [MaxLength(1024,ErrorMessage = "Descrição permite o máximo 1024 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1,int.MaxValue, ErrorMessage = "Valor deve ser maior que zero")]
        public decimal ValorUnitario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, long.MaxValue, ErrorMessage = "Quantidade deve ser maior que zero")]
        public long Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Tipo de produto inválido")]
        [ForeignKey("TipoProduto")]
        public int IdTipoProduto { get; set; }

        public DateTime DataInclusao { get; set; }


        #region Navigation

        public TipoProduto TipoProduto { get; set; }

        #endregion

    }
}
