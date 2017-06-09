using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class Shelf
    {
        private ICollection<Row> rows;

        public Shelf()
        {
            this.rows = new HashSet<Row>();
        }


        public int Id { get; set; }

        public string Number { get; set; }

        public int CurrentCapacity { get; set; }

        public int MaxCapacity { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        public virtual ICollection<Row> Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                this.rows = value;
            }
        }

    }
}