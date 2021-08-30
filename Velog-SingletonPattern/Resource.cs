#define LOCK//LOCK을 이용하여 synchronized 다른 방법 있으면 추가 예정

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Velog_SingletonPattern
{
    class Resource
    {
        private static int mineral;//미네랄
        private static int gas;//가스
        private static int maxPopulation;//맥스 인구수
        private static int population;//인구수

        private Resource()//생성자를 private로 하고 GetInstance로 개체 생성
        {
            mineral = 500;
            gas = 500;
            maxPopulation = 8;
            population = 0;
        }


#if LOCK
        private static object syncRoot = new object();
        private static Resource _instance = null;
        public static Resource Instance
        {
            get
            {
                if (_instance is null) //instance null일 경우 생성
                {
                    lock (syncRoot)//락을 이용하여 중복으로 개체가 생성되는 것 대비
                    {
                        if (_instance is null) //instance null일 경우 생성
                        {
                            _instance = new Resource();
                        }
                    }
                }

                return _instance;
            }
        }

        #region 내부 함수
        /// <summary>
        /// 현재 자원 알림
        /// </summary>
        private void Print() => System.Console.WriteLine($"mineral:{mineral}{Environment.NewLine}gas:{gas}{Environment.NewLine}population:{population}/{maxPopulation}");

        /// <summary>
        /// 유닛 생산
        /// </summary>
        private void ProduceUnit(string unit, int _mineral, int _gas, int _population)
        {
            mineral = mineral - _mineral;
            gas = gas - _gas;
            population = population + _population;
            Thread.Sleep(2000);
            System.Console.WriteLine($"{unit} 생산 완료");
            Print();
        }

        #endregion

        #region 외부 함수
        /// <summary>
        /// 자원 채취
        /// </summary>
        public void Work()
        {
            mineral = mineral + 8;
            gas = gas + 8;
            System.Console.WriteLine($"열심히 일중");
            Print();
        }

        /// <summary>
        /// 유닛 뽑기
        /// </summary>
        public void AddUnit(string unit)
        {
            switch (unit)
            {
                case "Marine":
                    ProduceUnit(unit, 50, 0, 1);
                    break;
                case "Firebat":
                    ProduceUnit(unit, 50, 25, 1);
                    break;
                case "Ghost":
                    ProduceUnit(unit, 50, 75, 1);
                    break;
                case "Medic":
                    ProduceUnit(unit, 50, 25, 1);
                    break;
            }
        }
        #endregion


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


