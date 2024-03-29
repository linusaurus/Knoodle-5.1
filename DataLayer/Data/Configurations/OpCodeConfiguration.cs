﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class OpCodeConfiguration : IEntityTypeConfiguration<OpCode>
    {
        public void Configure(EntityTypeBuilder<OpCode> entity)
        {
            entity.Property(e => e.OperationName).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OpCode> entity);
    }
}
