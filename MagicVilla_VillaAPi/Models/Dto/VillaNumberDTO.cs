﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPi.Models.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaId { get; set; }
        public string SpecialDetails { get; set; }
    }
}
