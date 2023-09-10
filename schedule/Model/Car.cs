using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schedule.Model
{
    [Table("m_car")]
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public int? view_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string car_model { get; set; }
    }
}
