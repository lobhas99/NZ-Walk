using System.ComponentModel.DataAnnotations;

namespace NZ_Walk_WebAPI.Models.DTO
{
    public class UpdateRegionRequestDTO
    {
        [Required]
        public string Code { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public string? RegionImageUrl { get; set; }
    }
}
