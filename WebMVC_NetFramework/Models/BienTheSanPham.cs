namespace WebMVC_NetFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BienTheSanPham")]
    public partial class BienTheSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBienThe { get; set; }

        public int? IDSanPham { get; set; }

        [Required]
        [StringLength(255)]
        public string CauHinh { get; set; }

        public int Gia { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
