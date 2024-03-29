﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> entity)
        {
            entity.HasIndex(e => e.RowID, "UQ__Resource__FFEE7450F82258EA")
                .IsUnique();

            entity.Property(e => e.Createdby).HasMaxLength(50);

            entity.Property(e => e.CreationDate).HasColumnType("date");

            entity.Property(e => e.FileSize).HasMaxLength(50);

            entity.Property(e => e.Lastmod).HasColumnType("date");

            entity.Property(e => e.ResourceDescription).HasMaxLength(240);

            entity.Property(e => e.ResourceFile).HasDefaultValueSql("(0x)");

            entity.Property(e => e.RowID).HasDefaultValueSql("(newid())");

            entity.Property(e => e.filesource).HasMaxLength(90);

            entity.HasOne(d => d.Part)
                .WithMany(p => p.Resource)
                .HasForeignKey(d => d.PartID)
                .HasConstraintName("FK_Resource_Part");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Resource> entity);
    }
}
