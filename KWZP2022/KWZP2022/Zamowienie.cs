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
    
    public partial class Zamowienie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zamowienie()
        {
            this.Szczegoly_zamowienia = new HashSet<Szczegoly_zamowienia>();
        }
    
        public int ID_zamowienie { get; set; }
        public int ID_klient { get; set; }
        public int ID_pracownik { get; set; }
        public System.DateTime Data_zamowienia { get; set; }
        public int ID_typ_zamowienia { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegoly_zamowienia> Szczegoly_zamowienia { get; set; }
        public virtual Typ_zamowienia Typ_zamowienia { get; set; }
    }
}