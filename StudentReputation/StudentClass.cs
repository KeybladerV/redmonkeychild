using System;
using System.ComponentModel;

namespace StudentReputation
{
    [Serializable]
    public class StudentClass
    {
        public string Name { get; set; }
        public BindingList<Student> Students { get; set; }

        public StudentClass()
        {
            Students = new BindingList<Student>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}