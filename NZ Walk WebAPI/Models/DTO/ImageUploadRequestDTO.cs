using System.ComponentModel.DataAnnotations;

namespace NZ_Walk_WebAPI.Models.DTO
{
    public class ImageUploadRequestDTO
    {
        [Required]
        public IFormFile File { get; set; }
        
        [Required]
        public string FileName { get; set; }

        public string? FileDescription { get; set; }

    }
}
