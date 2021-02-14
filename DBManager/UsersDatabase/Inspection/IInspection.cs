namespace DBManager.UsersDatabase.Inspection
{
    public interface IInspection
    {
        bool CheckIfUserInDatabaseByUsername(string username);
        bool CheckIfUsernamePasswordMatch(string username, string password);
    }
}