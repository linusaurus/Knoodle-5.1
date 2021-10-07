﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DataLayer.Data;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataLayer.Data.Configurations
{
    public partial class DocumentPartsConfiguration : IEntityTypeConfiguration<DocumentParts>
    {
        public void Configure(EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(e => new { e.PartID, e.DocID });

            entity.HasOne(d => d.Doc)
                .WithMany(p => p.DocumentParts)
                .HasForeignKey(d => d.DocID)
                .HasConstraintName("FK_DocumentParts_Document1");

            entity.HasOne(d => d.Part)
                .WithMany(p => p.DocumentParts)
                .HasForeignKey(d => d.PartID)
                .HasConstraintName("FK_DocumentParts_Part");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DocumentParts> entity);
    }
}