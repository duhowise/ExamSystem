using System;
using System.Linq;
using System.Windows.Forms;
using ExamSystem.Data;
using ExamSystem.Logic;
using ExamSystem.Services;
using ExamSystem.UI;
using Microsoft.Extensions.DependencyInjection;

namespace ExamSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = CreateServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var database = container.GetRequiredService<ExamDatabase>();

            var admin = database.Users.FirstOrDefault(x =>
                x.Password == "Administrator" && x.UserType == "Administrator");

            if (admin == null)
            {
                database.Users.Add(new User
                {
                    Password = "Administrator",
                    UserType = "Administrator",
                    Name = "Default Admin"
                });
                database.SaveChanges();
            }


            Application.Run(container.GetRequiredService<Login>());
        }

        public static IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddScoped<Login>();
            services.AddScoped<Admin>();
            services.AddScoped<QuestionPage>();
            services.AddScoped<TestPage>();
            services.AddScoped<DashBoard>();
            services.AddScoped<UserResult>();
            services.AddScoped<UserPage>();
            services.AddScoped<ViewResult>();
            services.AddScoped<AddTest>();
            services.AddScoped<AddQuestions>();
            services.AddScoped<AddCandidate>();


            services.AddSingleton<Yates>();
            services.AddSingleton<TestEvaluationService>();
            services.AddSingleton<ExamDatabase>();
            services.AddSingleton<UserInformationService>();
            services.AddSingleton<LoginService>();
            services.AddSingleton<QuestionService>();
            services.AddSingleton<TestService>();
            services.AddSingleton<UserInformationService>();
            services.AddSingleton<ApplicationUserStateService>();
          

            return services.BuildServiceProvider();
        }
    }
}