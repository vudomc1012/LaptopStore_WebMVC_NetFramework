using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebMVC_NetFramework.Models
{
    public partial class DBSanPhamContext : DbContext
    {
        public DBSanPhamContext()
            : base("name=DBSanPhamConnectionString")
        {
        }

        public virtual DbSet<BienTheSanPham> BienTheSanPhams { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BienTheSanPham>()
                .Property(e => e.CauHinh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenSanPham)
                .IsUnicode(false);
        }
    }
}
