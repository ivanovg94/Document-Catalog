using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class Box
    {
        private ICollection<Document> documents;

        public Box()
        {
            this.documents = new HashSet<Document>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public int CurrentCapacity { get; set; }

        public int MaxCapacity { get; set; }

        [ForeignKey("Row")]
        public int RowId { get; set; }
        public virtual Row Row { get; set; }

        public virtual ICollection<Document> Documents
        {
            get
            {
                return this.documents;
            }

            set
            {
                this.documents = value;
            }
        }
    }
}