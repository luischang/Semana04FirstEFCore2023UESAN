using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Semana04FirstEFCore.API.Models;

public partial class PeruDbContext : DbContext
{
    public PeruDbContext()
    {
    }

    public PeruDbContext(DbContextOptions<PeruDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<People> People { get; set; }
    public virtual DbSet<Product> Product { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2300143;Database=PeruDB;Integrated Security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<People>(entity =>
        {
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fullname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
