using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Payment_Registration_Application.Models;

public partial class PaymentRegistrationApplicationContext : DbContext
{
    public PaymentRegistrationApplicationContext()
    {
    }

    public PaymentRegistrationApplicationContext(DbContextOptions<PaymentRegistrationApplicationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PaymentDetail>(entity =>
        {
            entity.HasKey(e => e.PaymentDetailsId).HasName("PK__PaymentD__0994973BC8C030F2");

            entity.Property(e => e.CardNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CardOwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpiryDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
