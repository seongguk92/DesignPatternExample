using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new FacebookLogin().LoginUser();
            new KakaoLogin().LoginUser();
            new NaverLogin().LoginUser();
        }
    }
}
