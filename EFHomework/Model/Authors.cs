namespace EFHomework.Model
{
    public class Authors:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Foreign keys
        
        //Navigation Properties
        public List<Books> Books { get; set; }
    }
}
