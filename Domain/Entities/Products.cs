﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }    
        public string Description { get; set; } 
      
        public  float ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public DateTime Date { get; set; }

    }
}
