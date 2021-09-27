using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        public class MyClass
        {
            public int classField;
        }

        public struct MyStruct
        {
            public MyClass myObject;
        }
        public static void ProcessStruct(MyStruct str)
        {
            str.myObject.classField = 10;
        }

        static void Main(string[] args)
        {
            var str = new MyStruct();
            //str.myObject = new MyClass();
            ProcessStruct(str);
            Console.WriteLine(str.myObject.classField);

            Console.ReadKey();
        }
    }
}
