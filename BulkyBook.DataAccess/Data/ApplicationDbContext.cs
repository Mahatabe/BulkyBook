using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

namespace BulkyBook.DataAccess;

public class ApplicationDbContext: IdentityDbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

	public DbSet<Category> Categories { get; set; }
    public DbSet<CoverType> CoverTypes { get; set; }
    public DbSet<Product> Products { get; set; }
	//add-migration extendIdentityUser
	public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    //add-migration AddCompanyToUser
    public DbSet<Company> Companies { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
	//add-migration AddOrderHeaderAndDetailToDatabase
	public DbSet<OrderHeader> OrderHeaders { get; set; }
	public DbSet<OrderDetail> OrderDetail { get; set; }
}
