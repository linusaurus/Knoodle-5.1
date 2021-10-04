﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> entity)
        {
            entity.HasIndex(e => e.RowID, "UQ__Attachme__FFEE74505D190063")
                .IsUnique();

            entity.Property(e => e.AttachmentDescription)
                .HasMaxLength(520)
                .IsUnicode(false);

            entity.Property(e => e.BLOBData).HasDefaultValueSql("(0x)");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.Creator).HasMaxLength(30);

            entity.Property(e => e.FileSize).HasMaxLength(50);

            entity.Property(e => e.RowID).HasDefaultValueSql("(newid())");

            entity.Property(e => e.src)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.PurchaseOrder)
                .WithMany(p => p.Attachment)
                .HasForeignKey(d => d.PurchaseOrderID)
                .HasConstraintName("FK_Attachment_PurchaseOrder");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Attachment> entity);
    }
}
