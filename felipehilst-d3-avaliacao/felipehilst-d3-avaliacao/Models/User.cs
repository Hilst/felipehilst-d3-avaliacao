using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace felipehilst_d3_avaliacao.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column(TypeName = "user_id")]
        public int UserId { get; set; }

        [Column(TypeName = "nickname")]
        public string Nickname { get; set; } = "";

        [Column(TypeName = "email")]
        public string Email { get; set; } = "";

        [Column(TypeName = "psw")]
        public string Psw { get; set; } = "";
    }
}

