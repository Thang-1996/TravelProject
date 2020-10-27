using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAssigments.Models
{
    public class Location
    {
        public int id { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationDescription { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public int Status { get; set; }
    }
}