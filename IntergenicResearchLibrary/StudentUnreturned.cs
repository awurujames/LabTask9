namespace IntergenicResearchLibrary
{
    public class StudentUnreturned
    {
        public string StudentName{get;set;}
        public int StudentID{get;set;}
        public int YearStudy{get;set;}

        public Students(string studentname, int studentid, int yearstudy)
        {
            StudentName = studentName;
            StudentID = studentId;
            YearStudy = yearStudy;
        }
    }
}