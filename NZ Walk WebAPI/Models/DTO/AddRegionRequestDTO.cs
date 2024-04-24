using System.ComponentModel.DataAnnotations;

namespace NZ_Walk_WebAPI.Models.DTO
{
    public class AddRegionRequestDTO
    {
        [Required]
        [MinLength(3,ErrorMessage ="The length of the code is 3 characters")]
        [MaxLength(3,ErrorMessage ="The length of the code is 3 characters")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "The max length of the name is 100 characters")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
