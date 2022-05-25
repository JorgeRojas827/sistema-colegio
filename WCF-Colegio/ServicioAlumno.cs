using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        public bool DeleteAlumno(Int16 strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                ALUMNO objAlumno= (
                    from oAlumno in bdcolegio.ALUMNO
                    where oAlumno.IdAlumno == strId
                    select oAlumno).FirstOrDefault();

                bdcolegio.ALUMNO.Remove(objAlumno);
                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoBE> GetAllAlumnos()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<AlumnoBE> objListaAlumno = new List<AlumnoBE>();

                var query = (from oAlumno in bdcolegio.ALUMNO select oAlumno);

                foreach (var objAlumno in query)
                {
                    AlumnoBE objAlumnoBE = new AlumnoBE();

                    objAlumnoBE.Mvarid_alumno = (short) objAlumno.IdAlumno;
                    objAlumnoBE.Mvarnom_al = objAlumno.Nombres;
                    objAlumnoBE.Mvarape_al = objAlumno.Apellidos;
                    objAlumnoBE.Mvarcod_al = objAlumno.Codigo;
                    objAlumnoBE.Mvardocide_al = objAlumno.DocumentoIdentidad;
                    objAlumnoBE.Mvarfecnac_al = Convert.ToDateTime(objAlumno.FechaNacimiento);
                    objAlumnoBE.Mvarsex_al= objAlumno.Sexo;
                    objAlumnoBE.Mvarciu_al = objAlumno.Ciudad;
                    objAlumnoBE.Mvardir_al = objAlumno.Direccion;
                    objAlumnoBE.Mvarfecres_al = Convert.ToDateTime(objAlumno.FechaNacimiento);

                    objListaAlumno.Add(objAlumnoBE);
                }

                return objListaAlumno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Boolean InsertAlumno(AlumnoBE objAlumnoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                ALUMNO objAlumno = new ALUMNO();

                objAlumno.IdAlumno = objAlumnoBE.Mvarid_alumno;
                objAlumno.ValorCodigo = objAlumnoBE.Mvarvalorcod_al;
                objAlumno.Codigo = objAlumnoBE.Mvarcod_al;
                objAlumno.Nombres = objAlumnoBE.Mvarnom_al;
                objAlumno.Apellidos = objAlumnoBE.Mvarape_al;
                objAlumno.DocumentoIdentidad= objAlumnoBE.Mvardocide_al;
                objAlumno.FechaNacimiento= Convert.ToDateTime(objAlumnoBE.Mvarfecnac_al);
                objAlumno.Sexo= objAlumnoBE.Mvarsex_al;
                objAlumno.Ciudad = objAlumnoBE.Mvarciu_al;
                objAlumno.Direccion= objAlumnoBE.Mvardir_al;
                objAlumno.FechaRegistro= Convert.ToDateTime(objAlumnoBE.Mvarfecres_al);

                bdcolegio.ALUMNO.Add(objAlumno);

                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateAlumno(AlumnoBE objAlumnoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                ALUMNO objAlumno= (
                    from oAlumno in bdcolegio.ALUMNO
                    where oAlumno.Codigo == objAlumnoBE.Mvarcod_al
                    select oAlumno).FirstOrDefault();

                objAlumno.ValorCodigo = objAlumnoBE.Mvarvalorcod_al;
                objAlumno.Codigo = objAlumnoBE.Mvarcod_al;
                objAlumno.Nombres = objAlumnoBE.Mvarnom_al;
                objAlumno.Apellidos = objAlumnoBE.Mvarape_al;
                objAlumno.DocumentoIdentidad = objAlumnoBE.Mvardocide_al;
                objAlumno.FechaNacimiento = Convert.ToDateTime(objAlumnoBE.Mvarfecnac_al);
                objAlumno.Sexo = objAlumnoBE.Mvarsex_al;
                objAlumno.Ciudad = objAlumnoBE.Mvarciu_al;
                objAlumno.Direccion = objAlumnoBE.Mvardir_al;
                objAlumno.FechaRegistro = Convert.ToDateTime(objAlumnoBE.Mvarfecres_al);

                bdcolegio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
