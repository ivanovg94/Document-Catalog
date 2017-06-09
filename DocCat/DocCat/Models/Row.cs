using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class Row
    {

        private ICollection<Box> boxes;
        public Row()
        {
            this.boxes = new HashSet<Box>();
        }
        public int Id { get; set; }

        public string Number { get; set; }

        public int CurrentCapacity { get; set; }

        public int MaxCapacity { get; set; }

        [ForeignKey("Shelf")]
        public int ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }

        public virtual ICollection<Box> Boxes
        {
            get
            {
                return this.boxes;
            }

            set
            {
                this.boxes = value;
            }
        }
         }
}