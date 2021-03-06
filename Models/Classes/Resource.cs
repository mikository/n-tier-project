﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Resource
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public ResourseType Type { get; set; }
        public Bitmap Image { get; set; }
        public ResourceStatus Status { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string Description { get; set; }
        public DateTime DatePurchased { get; set; }
        public double Price { get; set; }
        public Student ReservedBy { get; set; }
    }
}
