﻿using System.ComponentModel.DataAnnotations;

namespace MilestoneLogistics.web.Models.ViewModels
{
    public class AddTagRequest
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? DisplayName { get; set; }
    }
}
