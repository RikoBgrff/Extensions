using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public static class ListExtensions
    {
        public static T GetMostWantedData<T>(this List<T> list)
        {
            if (list == null)
                Console.WriteLine("List if free");
            if (list.Count == 0)
              Console.WriteLine("There is no data!");

            var list2 = new List<T>();

            T returnAble = default;
            var maxCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list2.Contains(list[i]))
                    continue;

                list2.Add(list[i]);

                var count = list.Count(d => d.Equals(list[i]));

                if (count >= maxCount)
                {
                    returnAble = list[i];
                    maxCount = count;
                }
            }
            return returnAble;
        }
    }
}