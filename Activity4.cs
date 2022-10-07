using System;

namespace Activity4
{
    public interface School {
        string Name { get; set; }
        int NumberOfStudents { set; get; }
        string Address { set; get; }
        string Mascot { set; get; }
    }

    public class College : School {
        public string Name { get; set; }
        public int NumberOfStudents { set; get; }
        public string Address {set; get; }
        public string Mascot { set; get; }
    }

    public delegate string Mascot(string str);
    class EventExample {
        event Mascot School_Mascot;
        public string Mascot_Animal(string animal)
        {
            return "Mascot animal: " + animal;
        }
    }

    public class Shows<T>
    {
        private T[] arr = new T[10];
        
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class Testing 
    {
        static void Main(string[] args)
        {
            College Hunter = new College();
            Hunter.Name = "CUNY Hunter";
            Hunter.NumberOfStudents = 28000;
            Hunter.Address = "695 park ave";
            Console.WriteLine("Name: " + Hunter.Name);
            Console.WriteLine("Number of students: " + Hunter.NumberOfStudents);
            Console.WriteLine("Address: " + Hunter.Address);
            
            EventExample Hunter_Event = new EventExample();
            string a = Hunter_Event.Mascot_Animal("Hawk");
            Console.WriteLine(a);
            Hunter_Event.Mascot_Animal(a);
            
            
            var collect = new collection<string>();
            collect[0] = "Futurama";
            collect[1] = "Simpsons";
            collect[2] = "Famiy Guy";
            Console.WriteLine(collect[0]);
            Console.WriteLine(collect[1]);
            Console.WriteLine(collect[2]);
        }
    }
}