using System;
using System.Collections.Generic;

namespace Addresses.Models
{
    public partial class Address
    {
        public long Id { get; set; }
        public string? Street { get; set; }
        public long Housenumber { get; set; }
        public string? Zipcode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
