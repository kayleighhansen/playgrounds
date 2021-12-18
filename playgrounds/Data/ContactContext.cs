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

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.UseOpenIddict<int>();

        // }

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Organization> Organization { get; set; }

        // public DbSet<ContactInfo> ContactInfo { get; set; }
        // public DbSet<Date> Date { get; set; }

    }
