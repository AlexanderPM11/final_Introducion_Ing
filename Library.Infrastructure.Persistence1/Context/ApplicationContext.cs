using Library.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infrastructure.Persistence.Context
{
  public  class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Inventory> Inventory{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables
            modelBuilder.Entity<Book>()
            .HasOne<OrderDetail>(ord => ord.OrderDetail)
            .WithOne(book => book.Book)
            .HasForeignKey<OrderDetail>(book => book.BookId);



            modelBuilder.Entity<Book>()
            .HasOne(p => p.Gender)
            .WithMany(c => c.Books)
            .HasForeignKey(p => p.GenderId);



            modelBuilder.Entity<Book>()
            .HasOne<Inventory>(ord => ord.Inventory)
            .WithOne(book => book.Book)
            .HasForeignKey<Inventory>(book => book.BookId);

            #endregion

            #region primary key
            modelBuilder.Entity<Book>().HasKey(pk => pk.Id);
            modelBuilder.Entity<Inventory>().HasKey(pk => pk.Id);
            modelBuilder.Entity<Author>().HasKey(pk => pk.Id);
            modelBuilder.Entity<Gender>().HasKey(pk => pk.Id);
            modelBuilder.Entity<OrderDetail>().HasKey(pk => pk.Id);
            #endregion


        }

    }
}
