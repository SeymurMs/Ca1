using System;

namespace Ca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> mylist = new Mylist<string>();
            

            mylist[1] = "b";
            mylist[3] = "a";
            
            Console.WriteLine(mylist[1]);

            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
