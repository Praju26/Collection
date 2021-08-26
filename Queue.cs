using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class Queue
    {

        public Queue()
        {
            Queue<string> Vaccine = new Queue<string>();
            Vaccine.Enqueue("Priya Patil");
            Vaccine.Enqueue("Aditi Patil");
            Vaccine.Enqueue("Jenny Far");
            Vaccine.Enqueue("Advik Lade");
            Vaccine.Enqueue("Smit Patil");

            Console.WriteLine("Peoples are stand in queue for Vaccine:");
            foreach (string person in Vaccine)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine($"\n\nTotal people in queue stand for the Vassine Appointment: {Vaccine.Count}");
            Console.WriteLine($"First Person in queue: {Vaccine.Peek()}");
            Console.WriteLine($"{Vaccine.Dequeue()} got Appointment for the Vaccine. So now he/she is not in queue.");
            Console.WriteLine($"Is  stand in still in queue? {Vaccine.Contains("stand in ")}");

            Console.WriteLine("\n");
            string person2 = "";
            while (Vaccine.TryDequeue(out person2))
            {
                Console.WriteLine($"{person2} got Vaccine Appoinment");
            }
            Console.WriteLine($"\nTotal people in queue got Vzaccine Appointment: {Vaccine.Count}");
        }



    }
}
