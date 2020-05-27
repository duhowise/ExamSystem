using ExamSystem.UI;

namespace ExamSystem.Services
{
    public class AdminPageService:IPageService<Admin>
    {
        private readonly Admin _admin;

        public AdminPageService(Admin admin)
        {
            _admin = admin;
        }
        public Admin GetPage()
        {
            return _admin;
        }
    }
}