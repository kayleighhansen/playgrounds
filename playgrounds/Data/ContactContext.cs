using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Playgrounds.Models;

    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        public DbSet<Playgrounds.Models.Contact> Contact { get; set; }
        public DbSet<Playgrounds.Models.Note> Note { get; set; }
        public DbSet<Playgrounds.Models.Organization> Organization { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)

        // {
        //     modelBuilder.Entity<Note>().HasOne(m => m.DateAdded).WithMany(o => o.NoteDateAdded).OnDelete(DeleteBehavior.NoAction);

        // }
    }
