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
    
    public partial class Wytwarzanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Wytwarzanie()
        {
            this.Kontrola_jakosci_produkt = new HashSet<Kontrola_jakosci_produkt>();
            this.Proces_wytwarzanie_polprodukt = new HashSet<Proces_wytwarzanie_polprodukt>();
            this.Proces_wytwarzanie_produkt = new HashSet<Proces_wytwarzanie_produkt>();
        }
    
        public int ID_wytwarzanie { get; set; }
        public int ID_pracownik { get; set; }
        public int ID_zamowienie_szczegol { get; set; }
        public System.DateTime Czas_od { get; set; }
        public Nullable<System.DateTime> Czas_do { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontrola_jakosci_produkt> Kontrola_jakosci_produkt { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_wytwarzanie_polprodukt> Proces_wytwarzanie_polprodukt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_wytwarzanie_produkt> Proces_wytwarzanie_produkt { get; set; }
        public virtual Zamowienie_szczegol Zamowienie_szczegol { get; set; }
    }
}
