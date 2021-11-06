using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SolarSimulation_backend.Models
{
    public class Planet
    {
        [Key]
        [Required]
        public string Name { get; set; }
        [Required]
        public double Pos_x { get; set; }
        [Required]
        public double Pos_y { get; set; }
        [Required]
        public double Vx { get; set; }
        [Required]
        public double Vy { get; set; }
        [Required]
        public double Mass { get; set; }
        [Required]
        public double Radius { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
