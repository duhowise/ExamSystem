using System.Security.Principal;

namespace ExamSystem.Data
{
    public class CustomIdentity : IIdentity
    {
        private readonly User _user;

        public CustomIdentity(User user, string[] roles)
        {
            _user = user;
        }

        

        #region IIdentity Members

        public string Name => _user.Name;
        public User Credentials => _user;
        public string AuthenticationType => "Custom authentication";

        public bool IsAuthenticated => _user != null;

        #endregion
    }
}