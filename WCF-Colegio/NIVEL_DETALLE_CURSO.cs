//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Colegio
{
    using System;
    using System.Collections.Generic;
    
    public partial class NIVEL_DETALLE_CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NIVEL_DETALLE_CURSO()
        {
            this.DOCENTE_NIVELDETALLE_CURSO = new HashSet<DOCENTE_NIVELDETALLE_CURSO>();
            this.HORARIO = new HashSet<HORARIO>();
        }
    
        public int IdNivelDetalleCurso { get; set; }
        public Nullable<int> IdNivelDetalle { get; set; }
        public Nullable<int> IdCurso { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual CURSO CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCENTE_NIVELDETALLE_CURSO> DOCENTE_NIVELDETALLE_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HORARIO> HORARIO { get; set; }
        public virtual NIVEL_DETALLE NIVEL_DETALLE { get; set; }
    }
}