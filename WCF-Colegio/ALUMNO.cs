
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
    
public partial class ALUMNO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ALUMNO()
    {

        this.CALIFICACION = new HashSet<CALIFICACION>();

        this.MATRICULA = new HashSet<MATRICULA>();

    }


    public int IdAlumno { get; set; }

    public Nullable<int> ValorCodigo { get; set; }

    public string Codigo { get; set; }

    public string Nombres { get; set; }

    public string Apellidos { get; set; }

    public string DocumentoIdentidad { get; set; }

    public Nullable<System.DateTime> FechaNacimiento { get; set; }

    public string Sexo { get; set; }

    public string Ciudad { get; set; }

    public string Direccion { get; set; }

    public Nullable<bool> Activo { get; set; }

    public Nullable<System.DateTime> FechaRegistro { get; set; }

    public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }

    public string Usu_Ult_Mod { get; set; }

    public Nullable<int> Curso { get; set; }

    public Nullable<int> Nota { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CALIFICACION> CALIFICACION { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MATRICULA> MATRICULA { get; set; }

    public virtual CURSO CURSO1 { get; set; }

}

}
