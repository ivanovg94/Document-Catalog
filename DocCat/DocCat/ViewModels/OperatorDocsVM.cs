using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocCat.ViewModels
{
    public class OperatorDocsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string IssueBy { get; set; }
        public string  Status { get; set; }

    }
}