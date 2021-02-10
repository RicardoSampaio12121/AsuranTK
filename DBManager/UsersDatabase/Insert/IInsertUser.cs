using BusinessObjects.User;

namespace DBManager.UsersDatabase
{
    public interface IInsertUser : IDatabaseManager
    {
        void Insert(IUser user);

        bool CheckIfUserInDatabaseByUsername(string username);
    }
    
    
}