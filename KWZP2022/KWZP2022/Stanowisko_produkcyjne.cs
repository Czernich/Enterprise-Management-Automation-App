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
    
    public partial class Stanowisko_produkcyjne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stanowisko_produkcyjne()
        {
            this.Proces_polprodukt_czynnosc = new HashSet<Proces_polprodukt_czynnosc>();
            this.Proces_produkt_czynnosc = new HashSet<Proces_produkt_czynnosc>();
            this.Sklad_stanowisko_produkcyjne = new HashSet<Sklad_stanowisko_produkcyjne>();
            this.Sklad_stanowisko_produkcyjne_maszyna = new HashSet<Sklad_stanowisko_produkcyjne_maszyna>();
        }
    
        public int ID_stanowisko_produkcyjne { get; set; }
        public int ID_nazwa_stanowiska { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_polprodukt_czynnosc> Proces_polprodukt_czynnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_produkt_czynnosc> Proces_produkt_czynnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_stanowisko_produkcyjne> Sklad_stanowisko_produkcyjne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_stanowisko_produkcyjne_maszyna> Sklad_stanowisko_produkcyjne_maszyna { get; set; }
        public virtual Slownik_stanowisko Slownik_stanowisko { get; set; }
    }
}