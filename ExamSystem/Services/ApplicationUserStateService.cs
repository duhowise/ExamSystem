using ExamSystem.Data;

namespace ExamSystem.Services
{
    public class ApplicationUserStateService
    {
        private static User _user;
        private static int _testId;

        public static int TestId
        {
            get => _testId;
            set => _testId = value;
        }

        public static User User
        {
            get => _user;
            private set
            {
                if (value!=null)
                {
                    _user = value;
                }
            }
        }

        public void SetCurrentlyLoggedInUser(User user)
        {
            User = user;
        }
        public User CurrentlyLoggedInUser() => _user;
        public int GetTestId() => TestId;

        public void SetTestId(int testId)
        {
            TestId = testId;
        }

    }
}