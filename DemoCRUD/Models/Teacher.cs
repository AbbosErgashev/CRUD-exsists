﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DemoCRUD.Models
{
    public class Teacher
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Skills { get; set; }

        [Range(5, 50)]
        public int TotalStudents { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string AddedOn { get; set; }
    }
}
