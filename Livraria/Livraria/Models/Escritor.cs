using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace Livraria.Models
{
    [Table("Escritor")]
    public class Escritor
    {

        //aqi estou iniciando 
        public Escritor()
        {
            Livros = new Collection<Livro>();
        }


        [Key]
        public int ID_escritor { get; set; }

        [Required]
        [StringLength(150)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(80)]
        public string? Editora { get; set; }

        [Required]
        [StringLength(80)]
        public int Telefone {  get; set; }

        public Escritor(int iD_escritor, string? nome, string? editora, int telefone)
        {
            ID_escritor = iD_escritor;
            Nome = nome;
            Editora = editora;
            Telefone = telefone;
        }

        //chave 
        public ICollection<Livro>? Livros { get; set; }

        [JsonIgnore]
        public Livro? Escritores { get; set; }


    }
}
