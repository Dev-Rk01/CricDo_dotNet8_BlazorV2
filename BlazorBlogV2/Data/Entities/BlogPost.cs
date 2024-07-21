using System.ComponentModel.DataAnnotations;

namespace BlazorBlogV2.Data.Entities
{
	public class BlogPost
	{
		public long Id { get; set; }

		[Required, MaxLength(255)]
		public string Title { get; set; }

		[MaxLength(255)]
		public string Slug { get; set; }

		[Required, MaxLength(1000)]
		public string Image { get; set; }

		[Required, MaxLength(2000)]
		public string Introduction { get; set; }

		[Required]
		public string Content { get; set; }

		public long CategoryId { get; set; }

		public string UserId { get; set; }

		public bool IsPublished { get; set; }

		public int ViewCount { get; set; }
		public bool IsFeatured { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? PublishedAt { get; set; }

		public virtual Category Category { get; set; }
		public virtual ApplicationUser User { get; set; }
	}
}
