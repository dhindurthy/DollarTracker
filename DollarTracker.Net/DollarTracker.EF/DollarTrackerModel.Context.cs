﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DollarTracker.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;
    
    public partial class DollarTrackerEntities : DbContext
    {
        public DollarTrackerEntities(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
    	this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    	public DollarTrackerEntities(DbConnection connection) 
            : base(connection, true)
        {
        }
    
        public virtual DbSet<AppSetting> AppSetting { get; set; }
        public virtual DbSet<Collaborator> Collaborator { get; set; }
        public virtual DbSet<CustomExpenseCategory> CustomExpenseCategory { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public virtual DbSet<ExpenseStory> ExpenseStory { get; set; }
        public virtual DbSet<ExpenseStoryType> ExpenseStoryType { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
