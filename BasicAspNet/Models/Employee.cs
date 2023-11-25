using BasicAspNet.BusinessLayer.Entity;
using System;
using System.Collections.Generic;

namespace BasicAspNet.Models
{
    public partial class Employee:BaseEntity
    {
        public string Name { get; set; } = null!;
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
    }
}
