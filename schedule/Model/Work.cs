using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schedule.Model
{
    [Table("t_job")]
    public class Work
    {
        [Key]
        public int job_id { get; set; }

        public int? user_id { get; set; }

        public int? car_id { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? title { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? consignor { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_location { get; set; }

        public DateTime? put_on_day { get; set; }

        public bool put_on_time_flg { get; set; }

        public DateTime? put_on_time { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_post_code { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_prefectures { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_municipalities { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_building { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_location_2 { get; set; }

        public DateTime? put_on_day_2 { get; set; }

        public bool put_on_time_flg_2 { get; set; }

        public DateTime? put_on_time_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_post_code_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_prefectures_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_municipalities_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_building_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_location_3 { get; set; }

        public DateTime? put_on_day_3 { get; set; }

        public bool put_on_time_flg_3 { get; set; }

        public DateTime? put_on_time_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_post_code_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_prefectures_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_municipalities_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? put_on_building_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_location { get; set; }

        public DateTime? unload_day { get; set; }

        public bool unload_time_flg { get; set; }

        public DateTime? unload_time { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_post_code { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_prefectures { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_municipalities { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_building { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_location_2 { get; set; }

        public DateTime? unload_day_2 { get; set; }

        public bool unload_time_flg_2 { get; set; }

        public DateTime? unload_time_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_post_code_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_prefectures_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_municipalities_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_building_2 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_location_3 { get; set; }

        public DateTime? unload_day_3 { get; set; }

        public bool unload_time_flg_3 { get; set; }

        public DateTime? unload_time_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_post_code_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_prefectures_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_municipalities_3 { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? unload_building_3 { get; set; }

        public int? unit { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string? model { get; set; }

        public int? price { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? memo { get; set; }

        public int? checked_work { get; set; }
    }
}
