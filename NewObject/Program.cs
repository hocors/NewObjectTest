using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewObject
{
    public delegate void dgtPrint(string msg);

    public class object1
    {
        private static object locker = new object();
        private static object1 obj = null;

        private object1(dgtPrint pt)
        {
            pt("构造函数");
        }

        static object1()
        {
            Console.WriteLine("静态构造函数！");
        }

        public static object1 CreateInstance(dgtPrint pt)
        {
            lock (locker)
            {
                if (obj == null)
                    obj = new object1(pt);

                return obj;
            }
        }
    }

    public class object2
    {

    }
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static object NewObj()
        {
            dgtPrint dg = print;
            object1 obj = object1.CreateInstance(dg);
            return obj != null;
        }

        public static void print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
