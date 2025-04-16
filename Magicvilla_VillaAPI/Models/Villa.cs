using System;
using System.ComponentModel.DataAnnotations;

namespace Magicvilla_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
