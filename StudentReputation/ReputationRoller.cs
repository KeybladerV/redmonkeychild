using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentReputation
{
    public static class ReputationRoller
    {
        public static IEnumerable<StudentWin> RollLuck(StudentClass studentClass)
        {
            var studClass = studentClass.Students.Shuffle().ToList();
            var seed = studClass.Sum(student => (long) student.GetHashCode() + DateTime.Now.GetHashCode());

            Random random = new(unchecked((int) seed));

            return from student in studClass
                let rep = (int) student.Reputation
                where rep > 0
                select new StudentWin
                {
                    Student = student, Result = Enumerable.Repeat(random.Next(1, 100), rep).Average() * student.Reputation
                };
        }
    }

    public struct StudentWin
    {
        public Student Student { get; init; }
        public double Result { get; init; }
    }
}