using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private Bag myBag;
        private Electronics electronics;
        private Food food;

        public Facade()
        {
            myBag = new Bag();
            electronics = new Electronics();
            food = new Food();
        }

        public void trvelReady()
        {
            //처음 챙길려고 했던 물건
            myBag.AddItem("핸드폰", electronics.GetWeight("핸드폰"));
            myBag.AddItem("노트북", electronics.GetWeight("노트북"));
            myBag.AddItem("에어팟", electronics.GetWeight("에어팟"));
            myBag.AddItem("블루투스 스피커", electronics.GetWeight("블루투스 스피커"));

            myBag.AddItem("초콜릿", food.GetWeight("초콜릿"));
            myBag.AddItem("파", food.GetWeight("파"));
            myBag.AddItem("수박", food.GetWeight("수박"));
            myBag.AddItem("사탕", food.GetWeight("사탕"));

            myBag.ViewItemList();

            //가방이 생각보다 작아서 노트북을 빼고 음식을 더 다음
            myBag = new Bag();
            myBag.AddItem("핸드폰", electronics.GetWeight("핸드폰"));
            myBag.AddItem("에어팟", electronics.GetWeight("에어팟"));

            myBag.AddItem("초콜릿", food.GetWeight("초콜릿"));
            myBag.AddItem("파", food.GetWeight("파"));
            myBag.AddItem("수박", food.GetWeight("수박"));
            myBag.AddItem("과자", food.GetWeight("과자"));

            myBag.ViewItemList();
        }
    }
}
