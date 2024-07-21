using System.ComponentModel.DataAnnotations;

namespace BlazorBlogV2.Data.Entities
{
	public class Subscriber
	{
		public long Id { get; set; }

		[EmailAddress, Required, MaxLength(200)]
		public string Email { get; set; }

		[Required, MaxLength(50)]
		public string Name { get; set; }
		public DateTime SubscribedOn { get; set; }
	}
}
