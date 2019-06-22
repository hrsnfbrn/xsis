using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{

    [Table("x_address")]
    public class Address
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

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string address1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string postalcode1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string rt1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string rw1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string kelurahan1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string kecamatan1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string region1 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string address2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string postalcode2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string rt2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(5)]
        public string rw2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string kelurahan2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string kecamatan2 { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string region2 { get; set; }
    }
}