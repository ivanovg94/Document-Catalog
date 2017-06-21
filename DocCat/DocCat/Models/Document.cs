using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string IssuedTo { get; set; }


        public string DigitalPath { get; set; }

        [ForeignKey("Box")]
        public int BoxId { get; set; }
        public virtual Box Box { get; set; }

        [ForeignKey("IssuedBy")]
        public string IssuedById { get; set; }

        public virtual ApplicationUser IssuedBy { get; set; }

        public string SavedBy { get; set; }

        [ForeignKey("RequestStatus")]
        public int RequestStatusId { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }


        [ForeignKey("DocType")]
        public int DocTypeId { get; set; }

        public virtual DocType DocType { get; set; }
    //    public virtual TblFile TblFile { get; set; }





    }
}