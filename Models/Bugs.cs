﻿using System.ComponentModel.DataAnnotations;

namespace BTrack.Models

{
    public class Bugs
    {
        [Key] public int bugId { get; set; }
        public int bugStatus { get; set; }
        public string bugTitle { get; set; }
        public string bugDescription { get; set;}
        public int bugPriority { get; set; }
    }
}
