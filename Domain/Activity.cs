using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Activity
    {
        // allows to create id from server side and client side. thats why we are using Guid
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
