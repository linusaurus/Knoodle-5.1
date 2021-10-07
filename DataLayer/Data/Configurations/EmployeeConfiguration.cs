﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.Property(e => e.EmployeeEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Show).HasDefaultValueSql("((1))");

            entity.Property(e => e.firstname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.lastname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.middlename)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employee> entity);
    }
}