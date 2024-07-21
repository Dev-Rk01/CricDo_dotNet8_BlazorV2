using System.ComponentModel.DataAnnotations;

namespace BlazorBlogV2.Data.Entities
{
	public class Category
	{
		public long Id { get; set; }

		[Required, MaxLength(255)]
		public string Name { get; set; }

		[MaxLength(255)]
		public string Slug { get; set; }
		public bool ShowOnNavbar { get; set; }
	}
}
