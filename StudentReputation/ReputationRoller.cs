using System;
using System.Linq;

namespace StudentReputation
{
    public static class ReputationRoller
    {
        public static Student RollLuck(StudentClass studentClass)
        {
            var studClass = studentClass.Students.Shuffle().ToList();
            int seed = studClass.Sum(student => student.GetHashCode() + DateTime.Now.GetHashCode());

            Random random = new(seed);

            Student winner = null;
            double biggest = double.MinValue;
            foreach (var student in studClass)
            {
                int rep = (int) student.Reputation;
                if (rep <= 0)
                    continue;
                int[] rolls = new int[rep];
                for (int i = 0; i < rolls.Length; i++)
                {
                    rolls[i] = random.Next(0, 100);
                }

                var avg = rolls.Average();
                if (biggest < avg)
                {
                    biggest = avg;
                    winner = student;
                }
            }

            return winner;
        }
    }
}