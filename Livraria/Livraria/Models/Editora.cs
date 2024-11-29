using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;


namespace Livraria.Models
{

    [Table("Editoras")]
    public class Editora 
    {

        //aqui vou iniciar a cahve 
        public Editora()
        {
            Escritores = new Collection<Escritor>();
        }

        [Key]
        public int Id_Editora { get; set; }

        public string? Livros_Estoque { get; set; }
        public string? Endereco {  get; set; }

        public Editora(int id_Editora, string? livros_Estoque, string? endereco)
        {
            Id_Editora = id_Editora;
            Livros_Estoque = livros_Estoque;
            Endereco = endereco;
        }

        //chave 
        public ICollection<Escritor> Escritores { get; set; }


        [JsonIgnore]
        public Editora? Editoras { get; set; }

    }
}
