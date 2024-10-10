using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InfoBase
{


    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public ICollection<Branch> Branches { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }

    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Product> Products { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public Employee Employee { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<UserClaim> UserClaims { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public User User { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }
    }

    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
    }

    public class Color
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }

    public class Size
    {
        public int SizeId { get; set; }
        public string Description { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
    }

    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }

    public class ProductBrand
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
    }

    public class ProductSize
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
    }

    public class ProductImage
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }

    public class ProductPrice
    {
        public int ProductPriceId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
        public int? ColorId { get; set; }
        public Color Color { get; set; }
        public int? SizeId { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }
    }

    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<SaleProduct> SaleProducts { get; set; }
        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        public string Status { get; set; }
    }

    public class SaleProduct
    {
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int ProductPriceId { get; set; }
        public ProductPrice ProductPrice { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }

    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        public string Type { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }

    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }

    public class Claim
    {
        public int ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public ICollection<UserClaim> UserClaims { get; set; }
    }

    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }

    public class ProductColor
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
    }
    public class UserClaim
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ClaimId { get; set; }
        public Claim Claim { get; set; }
    }
}
