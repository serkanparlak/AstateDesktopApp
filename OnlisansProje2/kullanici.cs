//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlisansProje2
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanici
    {
        public kullanici()
        {
            this.ilans = new HashSet<ilan>();
        }
    
        public int ID { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string rol { get; set; }
    
        public virtual ICollection<ilan> ilans { get; set; }
    }
}
