using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Collection
{
    public class ArrayListdemo
    {

        public ArrayListdemo()
        {
            ArrayList arrayList1 = new ArrayList(100);
            arrayList1.Add(2);
            arrayList1.Add(1);
            //arrayLis1t.Add("Hello");
            arrayList1.Add(4);
            //arrayList1.Add(1.11);
            arrayList1.Add(3);
            arrayList1.Insert(0, 15);
            arrayList1.InsertRange(4, new int[] { 12, 13, 16, 17 });
            //arrayList1.Add("World");
            //arrayList1.Add(3.141f);

            Console.WriteLine("Before sorting");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\nDoes arrayList contains 5? {arrayList1.Contains(5)}");

            arrayList1.AddRange(new int[] { 9, 6, 5, 0 });

            Console.WriteLine($"Does arrayList contains 5? {arrayList1.Contains(5)}\n");

            arrayList1.Sort();

            Console.WriteLine("\nafter sorting in ascending order");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }

            arrayList1.Reverse();
            Console.WriteLine("\n\nafter sorting in decending order");
            foreach (var item in arrayList1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\n\narrayList length before trim: {arrayList1.Capacity}");
            arrayList1.TrimToSize();
            Console.WriteLine($"arrayList length after trim: {arrayList1.Capacity}");

            Console.WriteLine($"\nWhat is the index of number 12? {arrayList1.IndexOf(12)}");

            ArrayList repeatedList = ArrayList.Repeat(arrayList1, 2);

            Console.WriteLine("\nArrayList repeated 2 times");
            foreach (dynamic list in repeatedList)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }




    }
}








