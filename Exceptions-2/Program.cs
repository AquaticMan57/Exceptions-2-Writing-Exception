using Exceptions_2;
using System;
using System.Collections.Generic;

namespace Exceptions_2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass myclass = new MyClass() { };
            try
            {
                myclass.Function();
            }
            catch (RecordNotFoundException e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
    class MyClass : IClass
    {

        public void Function()
        {
            List<string> students = new List<string>() { "Eray", "Anil", "Yaman" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
    interface IClass
    {
        void Function();
    }
}
