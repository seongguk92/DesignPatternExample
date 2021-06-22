#define LOCK//LOCK을 이용하여 synchronized 다른 방법 있으면 추가 예정

using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance;
        private static string saveTime;
        private Singleton()//생성자를 private로 하고 GetInstance로 개체 생성
        {
            saveTime = $"{Guid.NewGuid():N}";
        }


#if LOCK
        private static object syncRoot = new object();
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance is null) //instance null일 경우 생성
                {
                    lock (syncRoot)//락을 이용하여 중복으로 개체가 생성되는 것 대비
                    {
                        if (_instance is null) //instance null일 경우 생성
                        {
                            _instance = new Singleton();
                        }
                    }
                }

                return _instance;
            }
        }

        public void Print() => System.Console.WriteLine($"SAVE TIME: {saveTime}");

#else
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                if (_instance is null) //instance null일 경우 생성 쓰레드로 동시에 접근 했을 경우 중복으로 생성이 되어 saveTime가 다를 것으로 보인다.
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        public void Print() => System.Console.WriteLine($"SAVE TIME: {saveTime}");
#endif
    }
}


