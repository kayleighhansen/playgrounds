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
    }
