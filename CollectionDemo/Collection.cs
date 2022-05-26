using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class Collection
    {
        public static void doSetDemo()
        {
            Console.WriteLine("/n doSetDemo");
            var set = new HashSet<string>();
            set.Add("ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator
                = set.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //Console.WriteLine(set[1]);
        }

        public static void doQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Shrama");

            queue.Enqueue("vijay raj");
            queue.Enqueue("jaishankar ");
            queue.Enqueue("Raj");
            Console.WriteLine("Head: "+queue.Peek());
            Console.WriteLine("/nIterating thwe queue elements : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue elements:"+dequeue);
            Console.WriteLine("/nIterating the queue elements after dequeu one elements:");


            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void doDictionoryDemo()
        {
            Console.WriteLine("/n doDictionay demo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("acess values using key(key=100):" + dictionary[100]);
            Console.WriteLine("Iterating Dictionary");
            foreach(var items in dictionary)
            {
                Console.WriteLine("key=0"+items.Key+"& Value="+items.Value);

            }
            Dictionary<int, string>.Enumerator obj = dictionary.GetEnumerator();
            while(obj.MoveNext())
            {
                Console.WriteLine(obj.Current);
            }
        }
        public static void doStackDemo()
        {
            Console.WriteLine("/n doStackDdemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashis");
            stack.Push("Garima");
            string pop = stack.Pop();
            foreach(var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped elements : "+pop);

        }
        public static void doListDemo()
        {
            Console.WriteLine("/nIn dolistDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            //list.Add(123);
            foreach (var elements in list)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine(list[3]);


        }
    }
}
