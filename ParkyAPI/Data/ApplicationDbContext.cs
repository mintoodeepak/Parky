using Microsoft.EntityFrameworkCore;
using ParkyAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbSet<NationalPark> NationalParks { get; set; } // after that need to push database and table to db through Package manager console

        //1. EntityFrameworkCore    2. Entityframeworkcore.sqlserver   3. Entityframeworkcore.Tools
        //Package manager console need to add migration to db
        //PM> add-migration AddNationalParkToDb
        //PM> update-database
        //4. Automapper  5. Automapper.Extensions.Microsoft.DependancyInjection
    }
}
