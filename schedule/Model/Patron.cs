using System.ComponentModel.DataAnnotations.Schema;

namespace schedule.Model
{
    [Table("m_patron")]
    public class Patron
    {
        public int Id { get; set; }

        public int PatronId { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string PatronName { get; set; }
    }
}
