using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IIServicioExtra" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIServicioExtra
    {
        [OperationContract]
        bool AsignarCursoDocente(int idCurso, int idDocente);

        [OperationContract]
        List<AlumnoBE> GetTopAlumnos(int maximo);

        [OperationContract]
        bool AsignarImagenCurso(Byte[] imagen, int idCurso);

        [OperationContract]
        List<AlumnoBE> GetAlumnosDeudores();

        [OperationContract]
        bool LoginUsuario(String usuario, String clave);
    }
}
