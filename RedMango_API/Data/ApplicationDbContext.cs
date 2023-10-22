﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RedMango_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {

        }
    }
}
