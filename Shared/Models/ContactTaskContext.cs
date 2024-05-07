using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContactListTask.Server.Models
{
    public partial class ContactTaskContext : DbContext
    {
        public ContactTaskContext()
        {
        }

        public ContactTaskContext(DbContextOptions<ContactTaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactList>? ContactLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ContactTask;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactList>(entity =>
            {
                entity.ToTable("ContactList");

                entity.Property(e => e.Email)
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
