using DBManager;

namespace Logic.Application
{
    public static class LoginController
    {
        public static bool Login(string username, string password)
        {
            var dbManager = DBManager.Factory.InitializeUsersDbInspection();
            return dbManager.CheckIfUsernamePasswordMatch(username, password);
        }
    }
}