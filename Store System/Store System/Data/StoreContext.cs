using Microsoft.EntityFrameworkCore;
using Store_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.Data
{
    internal class StoreContext:DbContext
    {
        public StoreContext()
        {
            
        }
        public StoreContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// PilsItems
            modelBuilder.Entity<Pillitems>()
                   .HasKey(ps => new { ps.product_Id, ps.Pill_Id });

            modelBuilder.Entity<Pillitems>()
                .HasOne(ps => ps.Product)
                .WithMany() 
                .HasForeignKey(ps => ps.product_Id);

            modelBuilder.Entity<Pillitems>()
                .HasOne(ps => ps.Pill)
                .WithMany() 
                .HasForeignKey(ps => ps.Pill_Id);


            /// ProductsSuppliers
            modelBuilder.Entity<ProductsSuppliers>()
       .HasKey(ps => new { ps.product_Id, ps.Supplier_Id });

            modelBuilder.Entity<ProductsSuppliers>()
                .HasOne(ps => ps.Product)
                .WithMany()
                .HasForeignKey(ps => ps.product_Id);

            modelBuilder.Entity<ProductsSuppliers>()
                .HasOne(ps => ps.Supplier)
                .WithMany()
                .HasForeignKey(ps => ps.Supplier_Id);

            ///========================
            modelBuilder.Entity<BranchSuppliers>()
            .HasKey(ps => new { ps.Supplier_Id, ps.Branch_Id });

            modelBuilder.Entity<BranchSuppliers>()
                .HasOne(ps => ps.Branch)
                .WithMany()
                .HasForeignKey(ps => ps.Branch_Id);

            modelBuilder.Entity<BranchSuppliers>()
                .HasOne(ps => ps.Supplier)
                .WithMany()
                .HasForeignKey(ps => ps.Supplier_Id);

        }



    }
}
