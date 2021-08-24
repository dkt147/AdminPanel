using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdminPanel.Models
{
    public class UsersContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        
    }
}