using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DuDoanTangTruong.Models
{
    public partial class Nhom18Context : DbContext
    {
        public Nhom18Context()
        {
        }

        public Nhom18Context(DbContextOptions<Nhom18Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TapLuat> TapLuats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EVJQ0DE\\SQLEXPRESS;Initial Catalog=Nhom18;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TapLuat>(entity =>
            {
                entity.HasKey(e => e.MaLuat)
                    .HasName("PK__TapLuat__2FEBABD4CEF9DC02");

                entity.ToTable("TapLuat");

                entity.Property(e => e.MaLuat).ValueGeneratedNever();

                entity.Property(e => e.CanNang).HasMaxLength(20);

                entity.Property(e => e.DoTuoi).HasMaxLength(10);

                entity.Property(e => e.KetQua).HasMaxLength(10);

                entity.Property(e => e.LuongSua).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
