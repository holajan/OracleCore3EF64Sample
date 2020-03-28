using System;
using System.Data.Entity;

namespace OracleCore3EF64Sample
{
    public class DataDbContextConfiguration : DbConfiguration
    {
        public DataDbContextConfiguration()
        {
            SetEFDataProvider();
        }

        private void SetEFDataProvider()
        {
            //Register DbProviderFactory for Oracle Data Provider for .NET, Managed Driver (ODP.NET)
            System.Data.Common.DbProviderFactories.RegisterFactory("Oracle.ManagedDataAccess.Client", Oracle.ManagedDataAccess.Client.OracleClientFactory.Instance);    //Instance of DbProviderFactory

            //Register Entity Framework provider
            SetProviderServices("Oracle.ManagedDataAccess.Client", Oracle.ManagedDataAccess.EntityFramework.EFOracleProviderServices.Instance); //Instance of DbProviderServices
        }
    }
}