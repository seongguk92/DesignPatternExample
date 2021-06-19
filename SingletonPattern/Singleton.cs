//#define LOCK//LOCK을 이용하여 synchronized 다른 방법 있으면 추가 예정

using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new object();
        private static string saveTime;
        private Singleton()//생성자를 private로 하고 GetInstance로 개체 생성
        {
            saveTime = DateTime.Now.ToString("F");
        } 


#if LOCK
        public static Singleton GetInstance()
        {
            if (instance is null) //instance null일 경우 생성
            {
                lock (syncRoot)//락을 이용하여 중복으로 개체가 생성되는 것 대비
                {
                    if (instance is null) //instance null일 경우 생성
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }

        public void Print() => System.Console.WriteLine($"SAVE TIME: {saveTime}");

#else
        public static Singleton GetInstance()
        {
            if (instance is null) //instance null일 경우 생성 쓰레드로 동시에 접근 했을 경우 중복으로 생성이 되어 saveTime가 다를 것으로 보인다.
            {
                instance = new Singleton();
            }

            return instance;
        }

        public void Print() => System.Console.WriteLine($"SAVE TIME: {saveTime}");
#endif
    }
}


