using System;
using System.Collections.Generic;

namespace StudentReputation
{
    [Serializable]
    public class ClassList
    {
        public List<StudentClass> StudentClasses { get; set; }

        public ClassList()
        {
            StudentClasses = new List<StudentClass>();
        }
    }
}