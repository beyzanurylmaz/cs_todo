using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TodoList.Models;

public partial class Atp11Context : DbContext
{
    public Atp11Context()
    {
    }

    public Atp11Context(DbContextOptions<Atp11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Todolist> Todolists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=atp11", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Todolist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("todolist");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.IsComplated).HasColumnType("bit(1)");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
