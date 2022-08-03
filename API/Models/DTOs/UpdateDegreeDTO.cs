﻿using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs
{
    public class UpdateDegreeDTO
    {
        public int DegreeId { get; set; }
        [Required]
        public string DegreeName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DurationInYears { get; set; }
    }
}
