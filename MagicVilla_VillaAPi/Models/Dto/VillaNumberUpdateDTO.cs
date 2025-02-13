using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPi.Models.Dto
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public string SpecialDetails { get; set; }
    }
}
