//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoTiendaWF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTORE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTORE()
        {
            this.VIDEOJUEGOS = new HashSet<VIDEOJUEGO>();
        }
    
        public int ID_PROD { get; set; }
        public string NOM_PROD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIDEOJUEGO> VIDEOJUEGOS { get; set; }
    }
}
