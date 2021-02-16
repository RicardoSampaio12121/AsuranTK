using BusinessObjects.User;
using DBManager;
using DBManager.UsersDatabase.Get;
using Org.BouncyCastle.Crypto.Parameters;

namespace Logic.Application
{
    public static class LoginController
    {
        public static (IUser user, bool success) Login(string username, string password)
        {
            var dbManager = DBManager.Factory.InitializeUsersDbInspection();
            var match = dbManager.CheckIfUsernamePasswordMatch(username, password);
            if(match == true)
            {
                var userGet = Factory.InitializeUserDbGet();
                var apiKey = userGet.UserApiKey(username);
                
                IUser outputUser = BusinessObjects.Factory.CreateUser();
                outputUser.Username = username;
                outputUser.Password = password;
                outputUser.Apikey = apiKey;

                return (outputUser, match);
            }

            return (null, match);


        }
    }
}