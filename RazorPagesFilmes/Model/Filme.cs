using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        //Propriedades link com BD.
        //string.Empty; ela vem vazia em vez de nulo.
        //DataAnnotations para personalizar a propriedade.
        public int ID { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Filme")]
        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite a Data de Lançamento do Filme")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Digite o Gênero do Filme")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o Preço do Filme")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Range(0, 10)]
        [Required(ErrorMessage = "Digite a Nota do Filme de 0 a 10")]
        public int Nota { get; set; } = 0;


    }
}
