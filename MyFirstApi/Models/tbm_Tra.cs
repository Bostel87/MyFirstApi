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
    
    public partial class tbm_Tra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbm_Tra()
        {
            this.tbm_Res = new HashSet<tbm_Res>();
        }
    
        public int co_tra { get; set; }
        public Nullable<int> co_loc { get; set; }
        public string tx_nom { get; set; }
        public string tx_ape { get; set; }
        public string tx_tel { get; set; }
        public string tx_corr { get; set; }
        public string tx_usu { get; set; }
        public string tx_con { get; set; }
        public System.DateTime fe_nac { get; set; }
        public System.DateTime fe_ing { get; set; }
        public Nullable<System.DateTime> fe_ultmod { get; set; }
        public string st_reg { get; set; }
    
        public virtual tbm_Loc tbm_Loc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbm_Res> tbm_Res { get; set; }
    }
}
