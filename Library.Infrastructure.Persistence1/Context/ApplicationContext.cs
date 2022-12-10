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

        ///Agregar el rateador de cambio para almacenar la fecha de los registro

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables
            modelBuilder.Entity<OrderDetail>()
            .HasOne<Book>(ord => ord.Book)
            .WithMany(book => book.OrderDetails)
            .HasForeignKey(ord => ord.BookId);


            modelBuilder.Entity<Book>()
            .HasOne(p => p.Gender)
            .WithMany(c => c.Books)
            .HasForeignKey(p => p.GenderId);


            modelBuilder.Entity<Book>()
            .HasOne(p => p.Author)
            .WithMany(c => c.Books)
            .HasForeignKey(p => p.AuthorId);



            modelBuilder.Entity<Inventory>()
            .HasOne<Book>(invt => invt.Book)
            .WithMany(book => book.Inventory)
            .HasForeignKey(invt => invt.BookId);

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
