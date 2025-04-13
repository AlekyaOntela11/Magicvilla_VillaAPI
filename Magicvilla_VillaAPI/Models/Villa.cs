using System;
using System.ComponentModel.DataAnnotations;

namespace Magicvilla_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}

