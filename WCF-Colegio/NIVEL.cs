
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
    
public partial class NIVEL
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NIVEL()
    {

        this.NIVEL_DETALLE = new HashSet<NIVEL_DETALLE>();

    }


    public int IdNivel { get; set; }

    public Nullable<int> IdPeriodo { get; set; }

    public string DescripcionNivel { get; set; }

    public string DescripcionTurno { get; set; }

    public Nullable<System.TimeSpan> HoraInicio { get; set; }

    public Nullable<System.TimeSpan> HoraFin { get; set; }

    public Nullable<bool> Activo { get; set; }

    public Nullable<System.DateTime> FechaRegistro { get; set; }



    public virtual PERIODO PERIODO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NIVEL_DETALLE> NIVEL_DETALLE { get; set; }

}

}
