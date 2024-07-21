using BlazorBlogV2.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlogV2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
		public DbSet<Category> Categories { get; set; }
		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<Subscriber> Subscribers { get; set; }
	}
}
