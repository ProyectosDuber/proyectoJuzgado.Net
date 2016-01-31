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
    using System.Linq;
    public partial class procesosJudiciales
    {
        public procesosJudiciales()
        {
            this.Involucrados = new HashSet<Involucrados>();
            this.Seguimientos = new HashSet<Seguimientos>();
        }
    
        public int idProcesosJudiciales { get; set; }
        public int tipoProceso { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public string asunto { get; set; }
        public string observaciones { get; set; }
        public Nullable<System.DateTime> fechaFinal { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<Involucrados> Involucrados { get; set; }
        public virtual tipoProceso tipoProceso1 { get; set; }
        public virtual ICollection<Seguimientos> Seguimientos { get; set; }
        public static int mtdNumeroDeProcesos(JuzgadoEntities db)
        {


            

            try
            {
                int numero = db.procesosJudiciales.Max(p => p.idProcesosJudiciales);
                return numero;



            }
            catch (Exception e)
            {
                return -1;

            }
        }
       
    }
}
