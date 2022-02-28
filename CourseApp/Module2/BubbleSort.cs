using System;
using System.Text;

namespace CourseApp.Module2
{
    public class BubbleSort
    {
        public static void Sort()
        {
            var countElems = Convert.ToInt32(Console.ReadLine());
            var array = new int[countElems];
            var inputStrings = Console.ReadLine().Split();
            for (var i = 0; i < countElems; i++)
            {
                array[i] = Convert.ToInt32(inputStrings[i]);
            }

            var sb = new StringBuilder();
            var swaps = false;
            for (var i = 0; i < array.Length; ++i)
            {
                for (var j = 0; j < array.Length - i - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        Console.WriteLine("{0}", sb.AppendJoin(" ", array));
                        sb.Clear();
                        swaps = true;
                    }
                }
            }

            if (swaps == false)
            {
                Console.WriteLine(0);
            }
        }
    }
}