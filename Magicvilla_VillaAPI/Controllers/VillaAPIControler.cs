using System;
using Magicvilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magicvilla_VillaAPI.Controllers
{
    [ApiController]
    [Route("api/VillaAPI")]
	public class VillaAPIControler : ControllerBase

	{
        [HttpGet]
        public IEnumerable<Villa> GetVillas()
		{
			return new List<Villa> {
			new Villa{Id=1,Name="Point View" },
			new Villa{Id=2,Name="Beach View" },
            new Villa{Id=3,Name="NewYork View" }
            };
		}
		public VillaAPIControler()
		{
		}
	}
}

