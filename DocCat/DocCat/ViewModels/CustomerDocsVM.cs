using System;
using System.Linq;

namespace DocCat.ViewModels
{
    public class CustomerDocsVM
    {
        private DateTime date;
        private string shortDesc;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string IssueTo { get; set; }
        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
            set { }
        }
        public string ShortDescription
        {
            get
            {
                if (shortDesc.Length > 20)
                {
                    return string.Concat(new string(shortDesc.Take(20).ToArray()), "...");
                }
                else
                {
                    return shortDesc;
                }
            }
            set { }
        }


        public string Description
        {
            get
            {
                return this.shortDesc;
            }
            set
            {
                this.shortDesc = value;
            }
        }

        public DateTime DateNTime
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

    }
}