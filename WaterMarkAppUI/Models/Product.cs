using System;
using System.ComponentModel.DataAnnotations;

namespace WaterMarkAppUI.Models
{
	public class Product
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public string? PictureUrl { get; set; }
	}
}

