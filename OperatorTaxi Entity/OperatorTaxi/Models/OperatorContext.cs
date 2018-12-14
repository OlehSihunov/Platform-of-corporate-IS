﻿namespace OperatorTaxi.Models
{
    using System.Data.Entity;

    class OperatorContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Taxist> Taxists { get; set; }
        public OperatorContext() : base("name=OperatorContext")
        {
        }
    }
}