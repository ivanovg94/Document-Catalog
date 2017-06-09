using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DocCat.Models
{
    public class TblFile
    {
        [Key]
        [ForeignKey("Document")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] File { get; set; }

        public virtual Document Document { get; set; }



  

    }
}