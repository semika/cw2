//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cw2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Type { get; set; }
        public string Occurence { get; set; }
        public string RecurrenceType { get; set; }
        public Nullable<int> OnDate { get; set; }
        public Nullable<int> OnMonth { get; set; }
    }
}