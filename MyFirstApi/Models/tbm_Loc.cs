//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbm_Loc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbm_Loc()
        {
            this.tbm_Tra = new HashSet<tbm_Tra>();
            this.tbm_Res = new HashSet<tbm_Res>();
        }
    
        public int co_loc { get; set; }
        public string tx_nom { get; set; }
        public string tx_des { get; set; }
        public string tx_dir { get; set; }
        public int co_hor { get; set; }
        public System.DateTime fe_ing { get; set; }
        public Nullable<System.DateTime> fe_ultmod { get; set; }
        public string st_reg { get; set; }
    
        public virtual tbm_Hor tbm_Hor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbm_Tra> tbm_Tra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbm_Res> tbm_Res { get; set; }
    }
}