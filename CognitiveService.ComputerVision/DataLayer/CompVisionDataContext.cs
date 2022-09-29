using CognitiveService.ComputerVision.DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveService.ComputerVision.DataLayer
{
    public class CompVisionDataContext : DbContext
    {

        public DbSet<dbComputerVision> dbComputerVision { get; set; }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G75N66U;Initial Catalog=DocService;Integrated Security=True");
            
        }

    }
}
