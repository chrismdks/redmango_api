﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedMango_API.Models;

namespace RedMango_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //constructor
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
