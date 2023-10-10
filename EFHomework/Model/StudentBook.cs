using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.Model
{
    public class StudentBook:Operations
    {
        public int Id { get; set; }

        //Foreign key
        public int StudentId { get; set; }
        public int BookId { get; set; }

        //Navigation Properties
        public Students student { get; set; }
        public List<Books> Books { get; set; }

    }
}
