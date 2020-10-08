using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProgram.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string NameVN { get; set; }
        public string NameEN { get; set; }
        public string Author { get; set; }
        public string LibraryCode { get; set; }
        public string Description { get; set; }
        public int PublishingCompany_Id { get; set; }
        public int StyleId { get; set; }

    }
}
