﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_adw97.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Zip Code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }

    }
}
