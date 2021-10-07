﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> entity)
        {
            entity.Property(e => e.AddedBy)
                .HasMaxLength(60)
                .IsFixedLength(true);

            entity.Property(e => e.DateAdded).HasColumnType("date");

            entity.Property(e => e.ExpectedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsBackOrder).HasDefaultValueSql("((0))");

            entity.Property(e => e.Memo)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(60)
                .IsFixedLength(true);

            entity.Property(e => e.ModifiedDate).HasColumnType("date");

            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.OrderFormat).HasMaxLength(50);

            entity.Property(e => e.OrderState).HasDefaultValueSql("((1))");

            entity.Property(e => e.OrderTotal)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");

            entity.Property(e => e.RecievedDate).HasColumnType("datetime");

            entity.Property(e => e.SalesRep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");

            entity.Property(e => e.ShipID).HasDefaultValueSql("((0))");

            entity.Property(e => e.ShippingCost)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.SubTotal)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.SuppressTax).HasDefaultValueSql("((0))");

            entity.Property(e => e.Tax)
                .HasColumnType("money")
                .HasDefaultValueSql("((0.0))");

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.EmployeeID)
                .HasConstraintName("FK_PurchaseOrder_Employee");

            entity.HasOne(d => d.Job)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.JobID)
                .HasConstraintName("FK_PurchaseOrder_Job");

            entity.HasOne(d => d.Supplier)
                .WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.SupplierID)
                .HasConstraintName("FK_PurchaseOrder_Supplier");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PurchaseOrder> entity);
    }
}