using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{

    [Table("Livros")]
    public class Livro
    {

        [Key]
        private int Id_livro { get; set; }

        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(80)]
        public int NumeroPagina { get; set; }

        [Required]
        [StringLength(150)]
        public string? Descricao { get; set; }

        [Required]
        [StringLength(80)]
        public string? Preco { get; set; }

        [Required]
        [StringLength(80)]
        public int? Estoque { get; set; }

        [Required]
        [StringLength(80)]
        public string Idioma { get; set; }

        [Required]
        [StringLength(80)]
        public DateTime? DataLancamento { get; set; }

        public Livro(int id_livro, string? nome, int numeroPagina, string? descricao, string? preco, 
            int? estoque, string idioma, DateTime? dataLancamento)
        {
            Id_livro = id_livro;
            Nome = nome;
            NumeroPagina = numeroPagina;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Idioma = idioma;
            DataLancamento = dataLancamento;

           


        }
    }
}
