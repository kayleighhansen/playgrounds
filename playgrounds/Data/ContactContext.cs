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

        public DbSet<Contact> Contact { get; set; }
        public DbSet<Date> Date { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }

    
        // protected override void OnModelCreating(ModelBuilder modelBuilder)

        // {
        //     modelBuilder.Entity<Contact>().HasOne(m => m.ContactInformation).WithMany(o => o.ContactInformationList).OnDelete(DeleteBehavior.NoAction);

        // }
    }
