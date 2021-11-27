using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FueraBugsDataManager.Models
{
    public partial class FueraBugsDataContext : DbContext
    {
        public FueraBugsDataContext()
        {
        }

        public FueraBugsDataContext(DbContextOptions<FueraBugsDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ticket> Ticket { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TN2RL74\\SQLEXPRESS;Database=FueraBugsData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
