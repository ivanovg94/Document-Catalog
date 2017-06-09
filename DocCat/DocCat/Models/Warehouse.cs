using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class Warehouse
    {
        private ICollection<Shelf> shelves;

        public Warehouse()
        {
            this.shelves = new HashSet<Shelf>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int CurrentCapacity { get; set; }

        public int MaxCapacity { get; set; }

        public virtual ICollection<Shelf> Shelves
        {
            get
            {
                return this.shelves;
            }
            set
            {
                this.shelves = value;
            }
        }


    }
}