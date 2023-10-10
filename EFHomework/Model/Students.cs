namespace EFHomework.Model
{
    public class Students : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string SchoolNumber { get; set; }
        public string PhoneNumber { get; set; }

        //Navigation Properties
        public List<Books> Books { get; set; }
    }
}
