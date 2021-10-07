﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> entity)
        {
            entity.HasKey(e => e.StockTransactionID)
                .HasName("PK_InventoryItems");

            entity.Property(e => e.DateStamp)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Description).HasMaxLength(512);

            entity.Property(e => e.InventoryAmount).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Location).HasMaxLength(120);

            entity.Property(e => e.Note).HasMaxLength(240);

            entity.Property(e => e.QntyOrdered)
                .HasColumnType("decimal(18, 4)")
                .HasDefaultValueSql("((0.0))");

            entity.Property(e => e.QntyReceived).HasColumnType("decimal(18, 4)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Inventory> entity);
    }
}