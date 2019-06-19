using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_keluarga")]
    public class Keluarga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public long created_by { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime created_on { get; set; }

        public Nullable<long> modified_by { get; set; }

        public Nullable<DateTime> modified_on { get; set; }

        public Nullable<long> deleted_by { get; set; }

        public Nullable<DateTime> deleted_on { get; set; }

        public Boolean is_delete { get; set; }

        public long biodata_id { get; set; }

        public Nullable<long> family_tree_type_id { get; set; }

        public Nullable<long> family_relation_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string name { get; set; }

        public Boolean gender { get; set; }

        [Column(TypeName = "Date")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> dob { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string job { get; set; }

        public Nullable<long> educational_level_id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string notes { get; set; }

    }
}
