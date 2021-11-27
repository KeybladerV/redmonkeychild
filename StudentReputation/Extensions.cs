using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentReputation
{
    public static class Extensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(a => Guid.NewGuid());
        }
    }
}