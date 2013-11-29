using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    
    class Program
    {
        //static void Main()
        //{
        //    sort obj = new sort();
        //    var t1 = new Thread(obj.RunBubbleSort);
        //    var t2 = new Thread(obj.RunHeapSort);
        //    var t3 = new Thread(obj.RunInsertSort);
        //    var t4 = new Thread(obj.RunMergeSort);
        //    var t5 = new Thread(obj.RunQuickSort);
        //    var t6 = new Thread(obj.RunSelectSort);
        //    t1.Start(20000000);
        //    t2.Start(20000000);
        //    t3.Start(20000000);
        //    t4.Start(20000000);
        //    t5.Start(20000000);
        //    t6.Start(20000000);                        

        //    Console.ReadLine();
        //}

        static void Main()
        {
            Class1 obj = new Class1();
            var t1 = new Thread(obj.execprocedure);
            t1.Start("exec insertnum 100000");
            Console.WriteLine("asdflkjsdkfj");
            Console.ReadLine();
        }
    }
}
