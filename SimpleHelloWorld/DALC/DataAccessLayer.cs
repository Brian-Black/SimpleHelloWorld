namespace SimpleHelloWorld
{
    using System.Configuration;

    public class DataAccessLayer
    {
        protected string ConnectionString = "";

        public DataAccessLayer()
        {
            ConnectionString = ConfigurationManager.AppSettings["DBConnecitonString"];
        }

        public DataAccessLayer(string connectionString)
        {
            ConnectionString = connectionString;
        }

    }
}
