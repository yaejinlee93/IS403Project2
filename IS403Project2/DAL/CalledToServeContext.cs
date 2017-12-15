using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IS403Project2.Models;
using System.Data.Entity;

namespace IS403Project2.DAL
{
    public class CalledToServeContext : DbContext
    {
        public CalledToServeContext() : base("CalledToServeContext")
        {

        }

        public DbSet<Missions> Mission { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<MissionQuestions> MissionQuestion { get; set; }
    }
}