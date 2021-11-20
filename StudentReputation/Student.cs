using System;
using System.Collections.Generic;

namespace StudentReputation
{
    [Serializable]
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<ReputationChange> ReputationChanges { get; set; }

        public Student()
        {
            ReputationChanges = new List<ReputationChange>();
        }
    }

    [Serializable]
    public struct ReputationChange
    {
        public DateTime DateTime;
        public float Reputation;
    }
}