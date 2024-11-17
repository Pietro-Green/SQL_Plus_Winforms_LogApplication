using System;
using System.Collections.Generic;
using BorNaplo;
using Microsoft.EntityFrameworkCore;

namespace BorNaplo.model;

public partial class Adatbazis : DbContext
{
    public Adatbazis()
    {
    }

    public Adatbazis(DbContextOptions<Adatbazis> options)
        : base(options)
    {
    }

    public virtual DbSet<BorNaplo> BorNaplos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\source\\repos\\BorNaplo\\bin\\Debug\\net8.0-windows\\database.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BorNaplo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BorNaplo__3214EC072227728D");

            entity.ToTable("BorNaplo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BorFajta).HasMaxLength(50);
            entity.Property(e => e.BorNev).HasMaxLength(50);
            entity.Property(e => e.KostolasHelyszin).HasMaxLength(50);
            entity.Property(e => e.KostolasIdopont).HasColumnType("datetime");
            entity.Property(e => e.PinceszetNev).HasMaxLength(50);
            entity.Property(e => e.RovidJellemzes).HasMaxLength(1000);
            entity.Property(e => e.SzoloFajta).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
