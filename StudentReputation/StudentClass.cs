using System;
using System.Collections.Generic;

namespace StudentReputation
{
    [Serializable]
    public class StudentClass
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public StudentClass()
        {
            Students = new List<Student>();
        }
    }
}