
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
    
public partial class Distrito
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Distrito()
    {

        this.ALUMNO = new HashSet<ALUMNO>();

        this.DOCENTE = new HashSet<DOCENTE>();

    }


    public int idDistrito { get; set; }

    public string nombre { get; set; }

    public string Descripcion { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ALUMNO> ALUMNO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DOCENTE> DOCENTE { get; set; }

}

}
