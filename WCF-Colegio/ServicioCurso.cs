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
                CURSO objCurso = new CURSO();

                objCursoBE.IdCurso = Int16.Parse(String.Empty);
                objCursoBE.Descripcion = objCurso.Descripcion;

                bdcolegio.CURSO.Add(objCurso);
                bdcolegio.SaveChanges();

                return true;
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
                CURSO objCurso = (
                        from oCurso in bdcolegio.CURSO
                        where oCurso.IdCurso == objCursoBE.IdCurso
                        select oCurso
                    ).FirstOrDefault();

                objCurso.IdCurso = objCursoBE.IdCurso;
                objCurso.Descripcion = objCursoBE.Descripcion;

                bdcolegio.SaveChanges();

                return true;
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
    }
}
