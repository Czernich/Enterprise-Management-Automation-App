//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wytworzony_produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wytworzony_produkt()
        {
            this.Kontrola_jakosci_produkt = new HashSet<Kontrola_jakosci_produkt>();
        }
    
        public int ID_wytworzony_produkt { get; set; }
        public int ID_produkt { get; set; }
        public System.DateTime Data_ukonczenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_jakosci_produkt> Kontrola_jakosci_produkt { get; set; }
        public virtual Produkt Produkt { get; set; }
    }
}