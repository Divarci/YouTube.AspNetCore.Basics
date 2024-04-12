namespace NewProject.Models
{
    public static class Books
    {
        public static List<string> BookList;

        static Books()
        {
            BookList = new List<string>()
            {
               "Book1","Book2","Book3"
            };
        }
    }
}
