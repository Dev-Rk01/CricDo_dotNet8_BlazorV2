using BlazorBlogV2.Data;
using Microsoft.AspNetCore.Identity;

namespace BlazorBlogV2.Services
{
	public static class AdminAccount
	{
		public const string Name = "CricDo";
		public const string Email = "cricdo@gmail.com";
        public const string Password = "CricDo@123";
		public const string Role = "Admin";

	}
	public class SeedService
	{
		private readonly ApplicationDbContext _context;
		private readonly IUserStore<ApplicationUser> _userStore;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		public SeedService(ApplicationDbContext context, IUserStore<ApplicationUser> userStore, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
		{
			_context = context;
			_userStore = userStore;
			_userManager = userManager;
			_roleManager = roleManager;
		}
		public async Task SeeddataAsync()
		{
			//Seed AdminRole
			
			//Seed Admin User

			//Seed Categories
		}
	}
}
