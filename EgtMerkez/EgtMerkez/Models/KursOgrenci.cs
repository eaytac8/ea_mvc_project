//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EgtMerkez.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KursOgrenci
    {
        public int KursOgrenciID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<double> Ucret { get; set; }
    
        public virtual Kurs Kurs { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
