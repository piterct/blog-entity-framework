﻿using FluentBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentBlog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Bio);
            builder.Property(x => x.Email);
            builder.Property(x => x.Image);
            builder.Property(x => x.PasswordHash);

            builder.Property(x => x.Slug)
             .IsRequired()
             .HasColumnName("Slug")
             .HasColumnType("VARCHAR")
             .HasMaxLength(80);

            builder.HasIndex(x => x.Slug, "IX_User_Slug")
               .IsUnique();

        }
    }
}
