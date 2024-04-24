﻿using System.ComponentModel.DataAnnotations;

namespace NZ_Walk_WebAPI.Models.DTO
{
    public class AddWalkRequestDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Required]
        public double LengthInKm { get; set; }
        
        public string? WalkImageUrl { get; set; }
        
        [Required]
        public Guid DifficultyId { get; set; }
        
        [Required]
        public Guid RegionId { get; set; }

    }
}
