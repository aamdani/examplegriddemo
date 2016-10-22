using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EditableGridExample.Models
{
    public partial class developContext : DbContext
    {
        public developContext(DbContextOptions<developContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.ID).IsRequired();
                entity.Property(e => e.contactID).IsRequired();
                entity.Property(e => e.description).IsRequired();
                entity.Property(e => e.typeID).IsRequired();
                entity.Property(e => e.altID).IsRequired();
                entity.Property(e => e.active).IsRequired();
                //entity.Property(e => e.createdDate).IsRequired(false);
                //entity.Property(e => e.updatedDate).IsRequired(false);
                entity.Property(e => e.updatedBy).IsRequired();
            });
        }

        public virtual DbSet<Event> Event { get; set; }
    }
}