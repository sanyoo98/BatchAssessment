﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Models
{
    public class Atribute
    {
       // public Guid BatchId { get; set; }
       //[Key]
        //public int Id { get; set; }
        [Key]
        [Required]
        public string Key { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
