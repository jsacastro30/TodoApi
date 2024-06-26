﻿using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; } = false;
    }
}
