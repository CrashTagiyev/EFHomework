using System.ComponentModel.DataAnnotations.Schema;

namespace EFHomework.Model
{
    public class Books : BaseEntity
    {
        public string Name { get; set; }
        public short PageCount { get; set; }

        //Foreign key
        public int AuthorId { get; set; }

        //Navigation Property
        public Authors Author { get; set; }
        public BookTypes BookType { get; set; }
    }
}
