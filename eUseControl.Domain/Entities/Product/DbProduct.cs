﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Product
{
    public class DbProduct
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string PreImgPath { get; set; }
    }
}
