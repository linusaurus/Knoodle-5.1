﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class WorkOrderConfiguration : IEntityTypeConfiguration<WorkOrder>
    {
        public void Configure(EntityTypeBuilder<WorkOrder> entity)
        {
            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.WorkOrderDate).HasColumnType("date");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkOrder> entity);
    }
}
