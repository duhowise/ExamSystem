using System.Windows.Forms;

namespace ExamSystem.Services
{
    public interface IPageService<T> where T:Form
    {
        T GetPage();

    }
}