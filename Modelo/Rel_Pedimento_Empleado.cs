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
    
    public partial class Rel_Pedimento_Empleado
    {
        public int ID_Rel_Pedimento { get; set; }
        public Nullable<int> ID_Pedimento { get; set; }
        public Nullable<int> ID_Empleado { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}
