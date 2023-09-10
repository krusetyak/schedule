using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schedule.Model
{
    [Table("m_user")]
    public class Users
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? name { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? password { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? email { get; set; }

        public bool? auth_flg { get;set; }
    }
}
