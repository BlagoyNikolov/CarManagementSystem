using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Web.Models
{
    public class AddVehicleViewModel
    {
        [UIHint("Enum")]
        public VehicleType VehicleType { get; set; }

        [Required]
        [StringLength(50)]
        [UIHint("SingleLineText")]
        public string Brand { get; set; }

        [Required]
        [StringLength(1000)]
        [UIHint("SingleLineText")]
        public string Model { get; set; }

        [UIHint("Number")]
        public int Year { get; set; }

        [UIHint("Number")]
        public int Mileage { get; set; }

        [Required]
        [UIHint("Number")]
        public int AverageMileage { get; set; }

        [Required]
        [StringLength(1000)]
        [UIHint("SingleLineText")]
        public string Color { get; set; }

        [Required]
        [UIHint("Number")]
        public double EngineDisplacement { get; set; }

        [UIHint("Number")]
        public int HorsePower { get; set; }

        [Required]
        [UIHint("Number")]
        public int Torque { get; set; }

        [UIHint("Enum")]
        public FuelType FuelType { get; set; }

        [StringLength(1000)]
        [UIHint("MultiLineText")]
        public string Description { get; set; }
    }
}