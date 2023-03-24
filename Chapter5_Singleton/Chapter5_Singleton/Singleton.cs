using System;

namespace Chapter05_Singleton
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler _Instance;
        private static readonly Object _lockObj = new Object();

        private static int objCnt = 0;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if (_Instance == null)
            {
                lock (_lockObj)
                {
                    if (_Instance == null)
                    {
                        objCnt++;
                        _Instance = new ChocolateBoiler();
                    }
                }
            }
            return _Instance;
        }

        public static int getObjCnt()
        {
            return objCnt;
        }
    }
}
