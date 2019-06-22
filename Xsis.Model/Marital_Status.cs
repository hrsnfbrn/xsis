using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_marital_status")]
    public class Marital_Status
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

        [Column(TypeName = "Varchar")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string description { get; set; }

    }
}
