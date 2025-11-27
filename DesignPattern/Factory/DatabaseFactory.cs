namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            //opens different types of databases -> our code is not database-dependent
            switch (type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();

                case DatabaseType.Oracle:
                    return new OracleDatabase();

                default:
                    throw new ArgumentException("Unsupported database type");
            }
        }
    }
}
