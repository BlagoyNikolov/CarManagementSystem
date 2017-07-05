using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Web.Models
{
    public class AddConsumativeViewModel
    {
        public Oil Oil { get; set; }
        public FuelFilter FuelFilter { get; set; }
        public Shock Shock { get; set; }
        public Tyre Tyre { get; set; }
        public Brake Brake { get; set; }
        public Belt Belt { get; set; }
        public int VehicleId { get; set; }
    }
}