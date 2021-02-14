using BusinessObjects.User;

namespace DBManager.UsersDatabase.Insert
{
    public interface IInsertUser : IDatabaseManager
    {
        void Insert(IUser user);
    }
    
    
}