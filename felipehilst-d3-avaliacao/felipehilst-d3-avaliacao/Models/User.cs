using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace felipehilst_d3_avaliacao.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; } = "";

        public string Email { get; set; } = "";

        public string Senha { get; set; } = "";
    }
}

