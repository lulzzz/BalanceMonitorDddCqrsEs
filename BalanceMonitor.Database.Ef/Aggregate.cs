//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BalanceMonitor.Database.Ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aggregate
    {
        public Aggregate()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int Id { get; set; }
        public System.Guid AggregateId { get; set; }
        public string AggregateType { get; set; }
    
        public virtual ICollection<Event> Events { get; set; }
    }
}