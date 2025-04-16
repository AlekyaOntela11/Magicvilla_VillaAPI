
using System;
using Magicvilla_VillaAPI.Models.Dto;

namespace Magicvilla_VillaAPI.Data
{
	public static class VillaStore
	{
		public static List<VillaDTO> villaList = new List<VillaDTO>
		{
			new VillaDTO{Id=1,Name="Point View", Sqft=100,Occupancy=4 },
			new VillaDTO{Id=2,Name="Beach View" ,Sqft=100,Occupancy=3},
			new VillaDTO{Id=3,Name="NewYork View" ,Sqft=100,Occupancy=5}
		};
	}
}

