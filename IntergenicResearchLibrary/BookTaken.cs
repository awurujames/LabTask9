namespace IntergenicResearchLibrary
{
    public class BookTaken
    {
        public string BookName{get;set;}
        public int BookID{get;set;}

        public Book(string bookName, string bookId) 
        {
            BookName = bookName;
            BookID = bookId;
        }
    }
}