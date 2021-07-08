using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class NaverLogin : SnsLogin
    {
        private string snsName = "네이버";

        protected override void Login()
        {
            Console.WriteLine($"{snsName} Login");
        }
        protected override void GetAccessToken()//접근 토큰 가져오기
        {
            Console.WriteLine($"{snsName} GetAccessToken");
        }
        protected override void PostAccessToken()//토큰 값 전송
        {
            Console.WriteLine($"{snsName} PostAccessToken");
        }
        protected override void GetUserInfo()//사용자 정보 가져오기
        {
            Console.WriteLine($"{snsName} GetUserInfo");
        }
    }
}
