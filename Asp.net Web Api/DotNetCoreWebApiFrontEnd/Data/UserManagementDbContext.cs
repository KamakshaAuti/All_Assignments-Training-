﻿using DotNetCoreWebApiFrontEnd.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiFrontEnd.Data
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext>options) :base(options)
        { 
            
        }
        public DbSet<UserDetails>UserDetails { get; set; }

    }
}
