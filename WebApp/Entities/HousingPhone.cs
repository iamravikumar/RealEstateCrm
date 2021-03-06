﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class HousingPhone
    {
        public int HousingPhoneId { get; set; }

        [Required]
        public int Order { get; set; }

        public string Number { get; set; }
    }
}
