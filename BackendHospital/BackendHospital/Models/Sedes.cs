//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendHospital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sedes
    {
        public int Id_Sedes { get; set; }
        public string Nombre_Sede { get; set; }
        public Nullable<int> Id_medico { get; set; }
    
        public virtual Medico Medico { get; set; }
    }
}
