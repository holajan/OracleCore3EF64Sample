using System;
using System.Data.Common;
using System.Data.Entity;

namespace OracleCore3EF64Sample
{
    public class DataDbContext : DbContext
    {
        private static class OracleConnectionFactoryAccesor
        {
            public static readonly Oracle.ManagedDataAccess.EntityFramework.OracleConnectionFactory OracleConnectionFactory = new Oracle.ManagedDataAccess.EntityFramework.OracleConnectionFactory();
        }

        public DataDbContext(string connectionString) : base(GetDbConnection(connectionString), true)
        {
            System.Data.Entity.Database.SetInitializer<DataDbContext>(null);

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            //Log SQL
            this.Database.Log = sql =>
            {
                if (!string.IsNullOrWhiteSpace(sql))
                {
                    Console.WriteLine("EF Trace: " + sql);
                }
            };
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("");  //Without dbo schema
        }

        private static DbConnection GetDbConnection(string connectionString)
        {
            //DbConfiguration must be instantiated before using EF context
            var dataDbContextConfiguration = new DataDbContextConfiguration();
            DbConfiguration.SetConfiguration(dataDbContextConfiguration);

            return OracleConnectionFactoryAccesor.OracleConnectionFactory.CreateConnection(connectionString);
        }


        //Entity
        public DbSet<PRODUCT_COMPONENT_VERSION> PRODUCT_COMPONENT_VERSION { get; set; }
    }
}