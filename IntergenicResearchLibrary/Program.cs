using System;

namespace IntergenicResearchLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentUnreturned myStudent1 = new StudentUnreturned("James", 345 - 345, 3);
            StudentUnreturned myStudent1 = new StudentUnreturned("Daze", 355 - 347, 4);
            StudentUnreturned myStudent1 = new StudentUnreturned("Dozie", 435 - 005, 3);


            BookTaken bookDetails1 = new BookTaken("Think Big start small", icr456);
            BookTaken bookDetails2 = new BookTaken("Purpose driven life", ibex456);
            BookTaken bookDetails3 = new BookTaken("The divine wisdom", ibex456);

            Library library1 = new Library(myStudent1, bookDetails1, 4,5,2011, 12,1,2020);
            Library library2 = new Library(myStudent2, bookDetails2, 8,2,2018, 5,20,2027);
            Library library3 = new Library(myStudent3, bookDetails3, 12,18,2019, 5,4,2020);

            GenericDefaulterList<IDefaulters> library = new GenericDefaulterList<IDefaulters>(); 

            library.Add(library1);                     
            library.Add(library2);                     
            library.Add(library3);    

            foreach(var items in library.GetDefaulter()) 
            {
                Console.WriteLine(items);
            }                
             



           


        }
    }
}
