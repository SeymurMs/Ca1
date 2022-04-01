using System;

namespace Ca1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(2002,9,28);

            //Console.WriteLine(date.DayOfWeek);           

            Console.WriteLine("Fullnme Daxil edin");

            string Fullname = Console.ReadLine();

            Student student1 = new Student();

            Student student2 = new Student();



        }
        static void FinishUni()
        {
            string dateTimeStr = Console.ReadLine();
            string dateTimeStr1 = Console.ReadLine();

            DateTime date1 = Convert.ToDateTime(dateTimeStr);
            DateTime date2 = Convert.ToDateTime(dateTimeStr1);
        }
        
    }
}
