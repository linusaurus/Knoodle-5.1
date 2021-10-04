﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class DeliveryItemConfiguration : IEntityTypeConfiguration<DeliveryItem>
    {
        public void Configure(EntityTypeBuilder<DeliveryItem> entity)
        {
            entity.Property(e => e.Description).HasMaxLength(50);

            entity.Property(e => e.ItemReferenceType)
                .HasMaxLength(10)
                .IsFixedLength(true);

            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DeliveryItem> entity);
    }
}
