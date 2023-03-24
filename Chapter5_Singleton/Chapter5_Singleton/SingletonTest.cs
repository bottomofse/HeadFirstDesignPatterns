using System;

namespace Chapter05_Singleton
{
    internal class SingletonTest
    {
        public static void exec()
        {
            var singleton1 = ChocolateBoiler.getInstance();
            Console.WriteLine(ChocolateBoiler.getObjCnt());

            var singleton2 = ChocolateBoiler.getInstance();
            Console.WriteLine(ChocolateBoiler.getObjCnt());

        }
    }
}
