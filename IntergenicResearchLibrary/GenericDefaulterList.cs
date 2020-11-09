using System;
using System.Collection.Generic;

namespace IntergenicResearchLibrary
{
    public class GenericDefaulterList<T> where T : IDefaulterList
    {
        public List<T> Libraries { get; set; } = new List<T>();

        public GenericDefaulterList(List<T> Libraries)
        {
            Libraries = libraries;
        }

    }
}