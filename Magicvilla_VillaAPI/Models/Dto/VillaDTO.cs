﻿
using System.ComponentModel.DataAnnotations;
namespace Magicvilla_VillaAPI.Models.Dto
{
	public class VillaDTO
	{
	public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		public string Name { get; set; }

		public int Occupancy { get; set; }

		public int Sqft { get; set; }
	}
}

