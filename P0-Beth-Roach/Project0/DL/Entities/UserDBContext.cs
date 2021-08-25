using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DL.Entities
{
    public partial class UserdbContext : DbContext
    {
        internal readonly object Id;
        internal readonly object Name;

        public UserdbContext()
        {
        }

        public UserdbContext(DbContextOptions<UserdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
                /*entity.Property(e=>e.rating)
                      .HasColumnType("float");*/

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
