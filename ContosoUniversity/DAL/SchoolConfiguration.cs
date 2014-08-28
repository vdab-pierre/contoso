using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration:DbConfiguration
    {
        public SchoolConfiguration()
        {
            //om connection resiliency aan te zetten
            SetExecutionStrategy("System.Data.SqlClient", (() => new SqlAzureExecutionStrategy()));
        }
    }
}