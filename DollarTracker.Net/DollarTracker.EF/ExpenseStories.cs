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
    
    public partial class ExpenseStories
    {
        public ExpenseStories()
        {
            this.Expenses = new HashSet<Expenses>();
        }
    
        public string ExpenseStoryId { get; set; }
        public System.Guid ExpenseStoryTypeId { get; set; }
        public Nullable<float> Budget { get; set; }
        public Nullable<float> Income { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime StartDt { get; set; }
        public System.DateTime EndDt { get; set; }
        public System.DateTime CreatedUtcDt { get; set; }
    
        public virtual ICollection<Expenses> Expenses { get; set; }
        public virtual ExpenseStoryTypes ExpenseStoryTypes { get; set; }
    }
}