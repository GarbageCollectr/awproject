﻿using System.ComponentModel.DataAnnotations;

namespace awprojectmodels
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "Name of State is required")]
        [StringLength(AwProjectConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }
        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(AwProjectConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}
