//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            this.Expense = new HashSet<Expense>();
        }
    
        public string ExpenseCategoryId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Expense> Expense { get; set; }
    }
}
