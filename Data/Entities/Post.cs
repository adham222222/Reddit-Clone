using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
	public class Post
	{
		public int Id { get; set; }

		[ForeignKey(User)]
		public int UserId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		public DateTime CreatedAt { get; set; }

		public User? User { get; set; }
	}
}
