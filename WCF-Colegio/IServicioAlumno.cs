using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        Boolean InsertAlumno(AlumnoBE objAlumnoBE);

        [OperationContract]
        Boolean UpdateAlumno(AlumnoBE objAlumnoBE);

        [OperationContract]
        Boolean DeleteAlumno(Int16 strId);

        [OperationContract]
        List<AlumnoBE> GetAllAlumnos();

        [OperationContract]
        AlumnoBE GetAlumno(Int16 strId);
    }

    [DataContract]
    [Serializable]
    public class AlumnoBE
    {
        // TODO
        private short mvarid_alumno;
        private Int16 mvarvalorcod_al;
        private String mvarcod_al;
        private String mvarnom_al;
        private String mvarape_al;
        private String mvardocide_al;
        private DateTime mvarfecnac_al;
        private String mvarsex_al;
        private String mvarciu_al;
        private String mvardir_al;
        private Boolean mvaract_al;
        private DateTime mvarfecres_al;
        private Int32 mvaridcurso;
        private Int32 mvarnota;        

        [DataMember]
        public short Mvarid_alumno { get => mvarid_alumno; set => mvarid_alumno = value; }
        [DataMember]
        public short Mvarvalorcod_al { get => mvarvalorcod_al; set => mvarvalorcod_al = value; }
        [DataMember] 
        public string Mvarcod_al { get => mvarcod_al; set => mvarcod_al = value; }
        [DataMember] 
        public string Mvarnom_al { get => mvarnom_al; set => mvarnom_al = value; }
        [DataMember] 
        public string Mvarape_al { get => mvarape_al; set => mvarape_al = value; }
        [DataMember] 
        public string Mvardocide_al { get => mvardocide_al; set => mvardocide_al = value; }
        [DataMember] 
        public DateTime Mvarfecnac_al { get => mvarfecnac_al; set => mvarfecnac_al = value; }
        [DataMember]
        public string Mvarsex_al { get => mvarsex_al; set => mvarsex_al = value; }
        [DataMember] 
        public string Mvarciu_al { get => mvarciu_al; set => mvarciu_al = value; }
        [DataMember] 
        public string Mvardir_al { get => mvardir_al; set => mvardir_al = value; }
        
        [DataMember] 
        public DateTime Mvarfecres_al { get => mvarfecres_al; set => mvarfecres_al = value; }

        [DataMember]
        public int Mvaridcurso { get => mvaridcurso; set => mvaridcurso = value; }
        [DataMember]
        public int Mvarnota { get => mvarnota; set => mvarnota = value; }
    }
}
