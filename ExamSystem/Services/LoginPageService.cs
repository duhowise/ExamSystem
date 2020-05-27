using System.Diagnostics.Eventing.Reader;
using ExamSystem.UI;

namespace ExamSystem.Services
{
    public class LoginPageService:IPageService<Login>
    {
        private readonly Login _login;

        public LoginPageService(Login login)
        {
            _login = login;
        }
        public Login GetPage()
        {
            return _login;
        }
    }
}