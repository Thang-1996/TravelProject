using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAssigments.Models
{
    public class Image
    {
        public int id { get; set; }
        public string imageurl { get; set; }
        public virtual Location Location { get; set; }
    }
}