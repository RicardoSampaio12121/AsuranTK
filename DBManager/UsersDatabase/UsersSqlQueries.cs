namespace DBManager.UsersDatabase
{
    public static class UsersSqlQueries
    {
        public const string InsertUserQuery = "INSERT INTO users (username, password, apikey) VALUES (@user, @pass, @api)";
    }
}