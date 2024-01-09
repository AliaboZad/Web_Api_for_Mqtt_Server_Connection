using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_Api_forMqttDatabase.Models
{
    public partial class MqttDatabase_for_testModelContext : DbContext
    {
        public MqttDatabase_for_testModelContext()
        {
        }

        public MqttDatabase_for_testModelContext(DbContextOptions<MqttDatabase_for_testModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Te> Tes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = .;Database=MqttDatabase_for_testModel; User Id = sa; Password = 1111;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Te>(entity =>
            {
                entity.ToTable("tes");

                entity.Property(e => e.Stringvalue).HasColumnName("stringvalue");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
