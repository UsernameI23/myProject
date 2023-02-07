using System;

namespace myProject
{
    class schoolwork
    {
        private static int _transactions = 0;
        private int _IDd;
        private string _Work;
        private string _Class;

        public schoolwork()
        {
            _IDd = 0;
            _Work = " ";
            _Class = " ";
        }
        public schoolwork(int i, string Work, string Class)
        {
            _IDd = i;
            _Work = Work;
            _Class = Class;

        }
        public int GetTrans()
        {
            return _transactions;
        }
        public int GetID()
        {
            return _IDd;
        }
        public string GetWork()
        {
            return _Work;
        }
        public string GetClass()
        {
            return _Class;
        }
        public void SetTrans(int _trans)
        {
            _transactions += _trans;
        }
        public void SetID(int identification)
        {
            _IDd = identification;
        }
        public void SetWork(string work)
        {
            _Work = work;
        }
        public void SetClass(string _class)
        {
            _Class = _class;
        }
    }
    class myStore
    {
        static void Main(string[] args)
        {
            schoolwork school3 = new schoolwork();
            school3.SetTrans(1);
            school3.SetID(30);
            school3.SetWork("Quantitative Reasoning Assignment");
            school3.SetClass("Statistics");

            schoolwork school2 = new schoolwork();
            school2.SetTrans(1);
            Console.WriteLine("Please enter your school ID: ");
            school2.SetID(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your schoolwork assignment: ");
            school2.SetWork(Console.ReadLine());
            Console.WriteLine("Please enter your class: ");
            school2.SetClass(Console.ReadLine());

            schoolwork school1 = new schoolwork(10, "Essay Assignment", "English");
            school3.SetTrans(1);

            Console.WriteLine("Please enter your school ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your schoolwork assignment: ");
            string tempWork = Console.ReadLine();
            Console.WriteLine("Please enter your class: ");
            string tempClass = Console.ReadLine();
            schoolwork school4 = new schoolwork(tempID, tempWork, tempClass);
            school4.SetTrans(1);

            Console.WriteLine($"You have {school1.GetTrans()} assignments");
            displayWork(school1);
            displayWork(school2);
            displayWork(school3);
            displayWork(school4);
        }

        static void displayWork(schoolwork member)
        {
            Console.WriteLine("Here's your schoolwork information");
            Console.WriteLine($"School ID: {member.GetID()}");
            Console.WriteLine($"Assignment Name: {member.GetWork()}");
            Console.WriteLine($"Class: {member.GetClass()}");
        }

    }

}
