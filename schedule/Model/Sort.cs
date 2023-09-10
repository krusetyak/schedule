using System.ComponentModel.DataAnnotations.Schema;

namespace schedule.Model
{
    public class Sort
    {
        public int Id { get; set; }

        public int code { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }
    }
}
