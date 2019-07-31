using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorProject2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string zipCode { get; set; }
        public string pickupDay { get; set; }
        public string OneTimePickup { get; set; }
        public string bill { get; set; }
        public string startAndEndDate { get; set; }
        public string weeklyPickupDay { get; set; }
    }
}