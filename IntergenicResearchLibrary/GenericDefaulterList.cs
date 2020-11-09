using System;
using System.Collection.Generic;

namespace IntergenicResearchLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulterList
    {
        public List<T> Libraries { get; set; } = new List<T>();

         private T[] defaulStudent;
        private int totalEle;
        private const int DEFAULTSIZE = 20;
        public GenericDefaulterList()
        {
            defaulStudent = new T[DEFAULTSIZE];
            totalEle = 0;
        }

        public GenericDefaulterList(int size) 
        {
            defaulStudent = new T[size];
            totalEle = 0;
        }

        public void Add(T item)
        {
            if(totalEle < defaulStudent.Length)
            {
                defaulStudent[totalEle] = item;
                totalEle++;
            }else{
                throw new System.Exception("defaulStudent collection is full...");
            }
        }

    

        public T[] GetDefaulter()
        {
            if(totalEle > 0)
            {
                return defaulStudent;
            }else{
                throw new System.Exception("defaulStudent collection is empty...");
            }
        }

    }
}