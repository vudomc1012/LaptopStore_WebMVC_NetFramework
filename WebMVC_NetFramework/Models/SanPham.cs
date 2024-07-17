namespace WebMVC_NetFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            BienTheSanPhams = new HashSet<BienTheSanPham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int IDSanPham { get; set; }
        [Display(Name = "Danh Mục")]
        public int? IDDanhMuc { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Tên sản phẩm" )]
        public string TenSanPham { get; set; }

        [StringLength(255)]
        [Display(Name = "Mô tả")] 
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienTheSanPham> BienTheSanPhams { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
    }
}
