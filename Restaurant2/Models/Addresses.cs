//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Addresses
    {
        public int AddressID { get; set; }
        public string Address { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Sokak { get; set; }
        public string ApartmanAdı { get; set; }
        public Nullable<int> AptNo { get; set; }
        public Nullable<int> Kat { get; set; }
        public Nullable<int> DaireNo { get; set; }
    
        public virtual users users { get; set; }
    }
}
