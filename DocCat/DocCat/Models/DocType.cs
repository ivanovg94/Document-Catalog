using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class DocType
    {

        private ICollection<Document> documents;

        public DocType()
        {
            this.documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

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