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
    
    public partial class Collaborators
    {
        public Collaborators()
        {
            this.Expenses = new HashSet<Expenses>();
        }
    
        public System.Guid CollaboratorId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserStoryId { get; set; }
        public System.DateTime CreatedUtcDt { get; set; }
        public bool Status { get; set; }
    
        public virtual ICollection<Expenses> Expenses { get; set; }
    }
}