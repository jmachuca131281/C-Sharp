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
    
    public partial class ALQUILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALQUILER()
        {
            this.ALQ_VIDEOJUEGOS = new HashSet<ALQ_VIDEOJUEGOS>();
        }
    
        public int ID_ALQUILER { get; set; }
        public System.DateTime FEC_ALQUILER { get; set; }
        public System.DateTime FEC_DEVOLUCION { get; set; }
        public decimal VLR_ALQUILER { get; set; }
        public decimal VLR_MULTAS { get; set; }
        public decimal NRO_DOC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALQ_VIDEOJUEGOS> ALQ_VIDEOJUEGOS { get; set; }
        public virtual PERSONA PERSONA { get; set; }
    }
}