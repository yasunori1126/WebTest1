﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class MvcBasicContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}