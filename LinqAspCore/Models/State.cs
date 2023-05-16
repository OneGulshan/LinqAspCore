﻿using System.ComponentModel.DataAnnotations;

namespace LinqAspCore.Models
{
    public class State
    {
        [Key]
        public int SId { get; set; }
        public int CId { get; set; }
        public string? Name { get; set; }
    }
}
