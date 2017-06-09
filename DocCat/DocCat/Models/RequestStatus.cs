using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class RequestStatus
    {
        private ICollection<Document> docs;

        public RequestStatus()
        {
            this.docs = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Document> Documents
        {
            get
            {
                return this.docs;
            }
            set
            {
                this.docs = value;
            }
        }
    }
}