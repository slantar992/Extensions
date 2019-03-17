using System;
using System.Collections.Generic;

namespace Slantar.Extensions
{
    public static class ListExtensions
    {
        public static void GenerateRandomValues(this List<int> source, int lenght, int init = 0, int minValue = -100, int maxValue = 100)
        {
            Random r = new Random();

            for(int i = init; i < lenght; i++)
            {
                source.ForceInsert(i, r.Next(minValue, maxValue));
            }
        }

        public static void ForceInsert<T>(this List<T> source, int index, T item)
        {
            if(index < source.Count)
            {
                source.Insert(index, item);
            }
            else
            {
                source.AddDefaults(source.Count, index);
                source.Add(item);
            }
        }

        public static void AddDefaults<T>(this List<T> source, int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                source.Add(default(T));
            }
        }
    }
}
