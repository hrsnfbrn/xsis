using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_biodata")]
    public class Biodata
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(255)]
        public string fullname { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string nick_name { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string pob { get; set; }

        [Column(TypeName = "Date")]
        public DateTime dob { get; set; }

        public Boolean gender { get; set; }

        public long religion_id { get; set; }

        public Nullable<int> high { get; set; }

        public Nullable<int> weight { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string nationality { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string ethnic { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(255)]
        public string hobby { get; set; }

        public long identity_type_id { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string identity_no { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(100)]
        public string email { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string phone_number1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string phone_number2 { get; set; }

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string parent_phone_number { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string child_sequence { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string how_many_brothers { get; set; }

        public long marital_status_id { get; set; }

        public Nullable<long> addrbook_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string token { get; set; }

        [Column(TypeName = "Date")]
        public Nullable<DateTime> expired_token { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string mariage_year { get; set; }

        public long company_id { get; set; }

        public Nullable<Boolean> is_process { get; set; }

        public Nullable<Boolean> is_complete { get; set; }
    }
}
