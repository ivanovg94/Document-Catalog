using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocCat.ViewModels
{
    public class CustomersVM
    {
        public string Name { get; set; }
        public string Bulstat { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int DocumentCount { get; set; }

    }
}