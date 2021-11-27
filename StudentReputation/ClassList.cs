using System;
using System.ComponentModel;

namespace StudentReputation
{
    [Serializable]
    public class ClassList
    {
        public BindingList<StudentClass> StudentClasses { get; set; }

        public event Action StudentClassesAdd;
        public event Action StudentClassesRemove;

        public ClassList()
        {
            StudentClasses = new BindingList<StudentClass>();
        }

        public void Add(StudentClass studentClass)
        {
            StudentClasses.Add(studentClass);
            StudentClassesAdd?.Invoke();
        }

        public void Remove(int index)
        {
            StudentClasses.RemoveAt(index);
            StudentClassesRemove?.Invoke();
        }

        public void Remove(StudentClass studentClass)
        {
            StudentClasses.Remove(studentClass);
            StudentClassesRemove?.Invoke();
        }
    }
}