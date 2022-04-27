//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export
    {
        public string ExportID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string AgentID { get; set; }
        public Nullable<System.DateTime> ExportDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string DeliveryStatus { get; set; }
        public string PaymentStatus { get; set; }
    
        public virtual Agent Agent { get; set; }
        public virtual Agent Agent1 { get; set; }
    }
}
