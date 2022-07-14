using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCurso" en el código y en el archivo de configuración a la vez.
    public class ServicioCurso : IServicioCurso
    {
        public Boolean InsertCurso(CursoBE objCursoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                var query = bdcolegio.usp_RegistrarCurso(objCursoBE.Descripcion);

                bdcolegio.SaveChanges();

                if (query == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public Boolean UpdateCurso(CursoBE objCursoBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.usp_EditarCurso(objCursoBE.IdCurso, objCursoBE.Descripcion,objCursoBE.Activocur);

                bdcolegio.SaveChanges();

                if (query == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean DeleteCurso(short strId)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                CURSO objCurso = (
                        from oCurso in bdcolegio.CURSO
                        where oCurso.IdCurso == strId
                        select oCurso
                    ).FirstOrDefault();

                bdcolegio.CURSO.Remove(objCurso);
                bdcolegio.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CursoBE> GetCursos()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<CursoBE> objListaCursos = new List<CursoBE>();

                var query = (from oCurso in bdcolegio.CURSO
                             select oCurso);
                foreach (var objCurso in query)
                {
                    CursoBE objCursoBE = new CursoBE();
                    objCursoBE.IdCurso = (short)objCurso.IdCurso;
                    objCursoBE.Descripcion = objCurso.Descripcion;

                    objListaCursos.Add(objCursoBE);
                }

                return objListaCursos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CursoBE GetCurso(Int32 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                CURSO objCurso = (

                from oCurso in MiColegio.CURSO
                where oCurso.IdCurso == strId
                select oCurso
                ).FirstOrDefault();

                CursoBE objCursoBE = new CursoBE();
                objCursoBE.IdCurso = Convert.ToInt16(objCurso.IdCurso);
                objCursoBE.Descripcion = objCurso.Descripcion;
                objCursoBE.FechaRegistro = Convert.ToDateTime(objCurso.FechaRegistro);
                objCursoBE.Imagen = objCurso.Imagen;
                
                return objCursoBE;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
