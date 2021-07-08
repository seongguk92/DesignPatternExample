using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class SnsLogin
    {
        protected abstract void Login();//로그인
        protected abstract void GetAccessToken();//접근 토큰 가져오기
        protected abstract void PostAccessToken();//토큰 값 전송
        protected abstract void GetUserInfo();//사용자 정보 가져오기

        public void LoginUser()
        {
            Login();
            GetAccessToken();
            PostAccessToken();
            GetUserInfo();
        }
    }
}
