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
    
    public partial class Rel_AA
    {
        public int ID_Rel_AA { get; set; }
        public Nullable<int> ID_AA { get; set; }
        public Nullable<int> ID_Contribuyente { get; set; }
        public Nullable<decimal> CuotaCorto { get; set; }
        public Nullable<decimal> CuotaMediano { get; set; }
        public Nullable<decimal> CuotaLargo { get; set; }
    
        public virtual Agentes_Aduanales Agentes_Aduanales { get; set; }
        public virtual Contribuyentes Contribuyentes { get; set; }
    }
}
