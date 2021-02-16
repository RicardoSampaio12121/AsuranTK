namespace DBManager.UsersDatabase
{
    public static class UsersSqlQueries
    {
        public const string InsertUserQuery = "INSERT INTO users (username, password, apikey) VALUES (@user, @pass, @api)";
        public const string CheckIfUsernameIsInDatabaseQuery = "SELECT COUNT(*) FROM users WHERE username = @user";

        public const string ConfirmPasswordFromUsername =
            "SELECT COUNT(*) FROM users WHERE username = @user AND password = @pass";

        public const string GetUserApiKeyQuery = "SELECT apikey FROM users WHERE username = @user";
    }
}