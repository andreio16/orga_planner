using System.Data.Entity;
using OrgaPlanner.Database.Storage.Models;

namespace OrgaPlanner.Storage.Database
{
    public class OrgaPlannerDbContext : DbContext
    {
        DbSet<Client> Clients { get; set; }

        public OrgaPlannerDbContext()
            : base("Data Source=MF1102ROP-AOA-W\\MSSQLSERVER01; Initial Catalog=OrgaPlanner; Integrated security=SSPI")
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
