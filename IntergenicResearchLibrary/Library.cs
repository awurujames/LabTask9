namespace IntergenicResearchLibrary
{
    public class Library : IDefaulterList
    {
        public StudentUnreturned StudentDetails{ get; set; }
        public BookTaken BookDetails{ get; set; }
        public int IssueDate { get; set; }
        public int ReturnDate { get; set; }
        public string ReturnStudentName { get; set; }
        public string ReturnedBookName { get; set; }

        public Library(StudentUnreturned StudentDetails, BookTaken BookDetails, int issueDate, int returnDate, string returnStudentName, string returnedBookName)
        {
            StudentDetails = studentDetails;
            BookDetails = bookDetails;
            IssueDate = issueDate;
            ReturnDate = returnDate;
            ReturnStudentName = returnStudentName;
            ReturnedBookName = returnedBookName;

        }

        public string GetName()
        {
            return $"Student Name : {StudentDetails.StudentName}";
        }

        public int GetYear()
        {
            return $"Student Year : {StudentDetails.YearStudy}";
        }

        public string GetBook()
        {
           return $"Book Name: {BookDetails.BookName}\nBook Id:{BookDetails.BookID}";
        }

        public int GetDateIssue()
        {
            return $"Date Issue : {IssueDate}";
        }

        public int GetDateReturn()
        {
            return $"Date Issue : {ReturnDate}";
        }






        
    }
}