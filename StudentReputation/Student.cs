using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentReputation
{
    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public float Reputation => ReputationChanges.Sum(rc => rc.Reputation);

        public List<ReputationChange> ReputationChanges { get; set; }

        public Student()
        {
            ReputationChanges = new List<ReputationChange>();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    [Serializable]
    public struct ReputationChange
    {
        public DateTime DateTime { get; set; }
        public float Reputation { get; set; }
    }
}