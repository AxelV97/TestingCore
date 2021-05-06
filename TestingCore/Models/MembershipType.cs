﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestingCore.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public short SignUpFee { get; set; }
        public short DurationInMonths { get; set; }
        public short DiscountRate { get; set; }
    }
}
