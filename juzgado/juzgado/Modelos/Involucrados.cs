//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace juzgado.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Involucrados
    {
        public int idInvolucrados { get; set; }
        public string tipo { get; set; }
        public int usuario { get; set; }
        public int procesoJudicial { get; set; }
        public string estado { get; set; }
    
        public virtual procesosJudiciales procesosJudiciales { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
