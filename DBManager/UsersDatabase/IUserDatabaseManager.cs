using BusinessObjects.User;

namespace DBManager.UsersDatabase
{
    public interface IUserDatabaseManager : IDatabaseManager
    {
        void Insert(IUser user);
    }
}