//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicios()
        {
            this.Pedimento = new HashSet<Pedimento>();
        }
    
        public int ID_Servicio { get; set; }
        public string Servicio { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedimento> Pedimento { get; set; }
    }
}
