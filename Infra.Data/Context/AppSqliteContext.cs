using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Context
{
    public class AppSqliteContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductBrand> ProductBrands { get; set; }
        //public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<ProductPrice> ProdutoPrices { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleProduct> SaleProducts { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }



        public AppSqliteContext(DbContextOptions<AppSqliteContext> options)
      : base(options)
        {

        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
