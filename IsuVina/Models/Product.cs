//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsuVina.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitBrief { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public Nullable<bool> Available { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<bool> Special { get; set; }
        public string Latest { get; set; }
        public Nullable<int> Views { get; set; }
    }
}
