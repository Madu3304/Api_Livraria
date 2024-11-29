using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Livraria.Models
{

    [Table("Generos")]
    public class Genero
    {     

        //aqui estou iniciando a chave KEY
        public Genero()
        {
            Livros = new Collection<Livro>();
        }

        [Key]
        public int Id_Genero { get; set; }

        [Required]
        [StringLength(80)]
        public string? Fantasia { get; set; }

        [Required]
        [StringLength(80)]
        public string? Romance { get; set; }

        [Required]
        [StringLength(80)]
        public string? Terror { get; set; }

        [Required]
        [StringLength(80)]
        public string? Comedia { get; set; }

        [Required]
        [StringLength(80)]
        public string? Aventura { get; set; }

        public Genero(int id_Genero, string? fantasia, string? romance, string? terror, string? comedia, string? aventura)
        {
            Id_Genero = id_Genero;
            Fantasia = fantasia;
            Romance = romance;
            Terror = terror;
            Comedia = comedia;
            Aventura = aventura;
        }

        //recebendo chave 
        public ICollection<Livro>? Livros { get; set; }

        [JsonIgnore]
        public Genero? Generos { get; set; }

    }
}
