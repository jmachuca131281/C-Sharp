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
    
    public partial class ALQ_VIDEOJUEGOS
    {
        public int ID_ALQ_VIDEOJUEGO { get; set; }
        public int ID_ALQUILER { get; set; }
        public int NRO_REFERENCIA { get; set; }
    
        public virtual ALQUILER ALQUILER { get; set; }
        public virtual VIDEOJUEGO VIDEOJUEGO { get; set; }
    }
}
