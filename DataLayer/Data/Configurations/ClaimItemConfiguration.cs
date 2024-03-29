﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class ClaimItemConfiguration : IEntityTypeConfiguration<ClaimItem>
    {
        public void Configure(EntityTypeBuilder<ClaimItem> entity)
        {
            entity.Property(e => e.Bcode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DefectDescription)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClaimItem> entity);
    }
}
