using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace OracleCore3EF64Sample
{
    public class PRODUCT_COMPONENT_VERSION
    {
        [Key]
        public string PRODUCT { get; set; }
        public string VERSION { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Add connection string
            string connectionString = "Data Source=;User Id=;Password=;";

            using (var dbContext = new DataDbContext(connectionString))
            {
                var result = (from productComponentVersion in dbContext.PRODUCT_COMPONENT_VERSION
                              orderby productComponentVersion.PRODUCT
                              select new
                              {
                                  Product = productComponentVersion.PRODUCT,
                                  Version = productComponentVersion.VERSION
                              }).ToList();

                Console.WriteLine($"Result:");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Product} - {item.Version}");
                }
            }
        }
    }
}