namespace DBManager.UsersDatabase
{
    public static class UsersSqlQueries
    {
        public const string InsertUserQuery = "INSERT INTO users (username, password, apikey) VALUES (@user, @pass, @api)";
        public const string CheckIfUsernameIsInDatabaseQuery = "SELECT COUNT(*) FROM users WHERE username = @user";
    }
}