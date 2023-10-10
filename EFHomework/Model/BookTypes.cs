namespace EFHomework.Model
{
    public class BookTypes:BaseEntity
    {
        public string Name { get; set; }

        //Foreign key
        public int BooksId { get; set; }

        //Navigation Property
        public List<Books> Books { get; set; }
    }
}
