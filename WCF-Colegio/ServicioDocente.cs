using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Colegio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDocente" en el código y en el archivo de configuración a la vez.
    public class ServicioDocente : IServicioDocente
    {
        public bool DeleteDocente(Int32 strCod)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                DOCENTE objDocente = (
                    from oDocente in bdcolegio.DOCENTE
                    where oDocente.IdDocente == strCod
                    select oDocente).FirstOrDefault();

                bdcolegio.DOCENTE.Remove(objDocente);
                bdcolegio.SaveChanges();
                return true;


            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<DocenteBE> GetAllDocentes()
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<DocenteBE> objListaDocente = new List<DocenteBE>();

                var query = (from oDocente in bdcolegio.DOCENTE select oDocente);

                foreach (var objDocente in query)
                {

                    DocenteBE objDocenteBE = new DocenteBE();

                    objDocenteBE.Id_Docente1 = objDocente.IdDocente;
                    objDocenteBE.Nombres = objDocente.Nombres;
                    objDocenteBE.Apellidos = objDocente.Apellidos;
                    objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                    objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                    objDocenteBE.Fecha_regi = Convert.ToDateTime(objDocente.FechaRegistro);
                    objDocenteBE.Sexo = objDocente.Sexo;
                    objDocenteBE.Ciudad = objDocente.Ciudad;
                    objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                    objDocenteBE.Direccion1 = objDocente.Direccion;
                    objDocenteBE.Email = objDocente.Email;
                    objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                    objDocenteBE.Codigo = objDocente.Codigo;
                    objDocenteBE.Valor_codigo = Convert.ToInt32(objDocente.ValorCodigo);
                    objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);


                    objListaDocente.Add(objDocenteBE);




                }
                return objListaDocente;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public bool InsertDocente(DocenteBE objDocenteBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                var query = bdcolegio.usp_RegistrarDocente(objDocenteBE.DNI1, objDocenteBE.Nombres,
                    objDocenteBE.Apellidos, objDocenteBE.FechaNac, objDocenteBE.Sexo,
                    objDocenteBE.Grado_estudio, objDocenteBE.Ciudad, objDocenteBE.Direccion1, objDocenteBE.Email, objDocenteBE.Numero_tel1);

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

        public bool UpdateDocente(DocenteBE objDocenteBE)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();

            try
            {
                var query = bdcolegio.usp_EditarDocente(objDocenteBE.Id_Docente1,objDocenteBE.Codigo,objDocenteBE.DNI1, objDocenteBE.Nombres, objDocenteBE.Apellidos, objDocenteBE.FechaNac,
                                                        objDocenteBE.Sexo, objDocenteBE.Grado_estudio, objDocenteBE.Ciudad, objDocenteBE.Direccion1,
                                                        objDocenteBE.Email, objDocenteBE.Numero_tel1, objDocenteBE.Mvaract_doc, objDocenteBE.Usu_ult_mod);

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

            //try
            //{

            //    DOCENTE objDocente = (

            //        from oDocente in bdcolegio.DOCENTE
            //        where oDocente.IdDocente == objDocenteBE.Id_Docente1
            //        select oDocente).FirstOrDefault();

            //    objDocente.IdDocente = objDocenteBE.Id_Docente1;
            //    objDocente.Codigo = objDocenteBE.Codigo;
            //    objDocente.ValorCodigo = objDocenteBE.Valor_codigo;
            //    objDocente.Nombres = objDocenteBE.Nombres;
            //    objDocente.Apellidos = objDocenteBE.Apellidos;
            //    objDocente.Direccion = objDocenteBE.Direccion1;
            //    objDocente.Sexo = objDocenteBE.Sexo;
            //    objDocente.DocumentoIdentidad = objDocenteBE.DNI1;
            //    objDocente.FechaNacimiento = objDocenteBE.FechaNac;
            //    objDocente.FechaRegistro = objDocenteBE.Fecha_regi;
            //    objDocente.NumeroTelefono = objDocenteBE.Numero_tel1;
            //    objDocente.Email = objDocenteBE.Email;
            //    objDocente.IdCurso = objDocenteBE.Id_Curso1;


            //    bdcolegio.SaveChanges();

            //    return true;




            //}
            //catch (EntityException ex)
            //{

            //    throw new Exception(ex.Message);
            //}


        }

        public DocenteBE GetDocente(Int32 strId)
        {
            BDCOLEGIOEntities MiColegio = new BDCOLEGIOEntities();

            try
            {
                DOCENTE objDocente = (

                from oDocente in MiColegio.DOCENTE
                where oDocente.IdDocente == strId
                select oDocente
                ).FirstOrDefault();

                DocenteBE objDocenteBE = new DocenteBE();
                objDocenteBE.Id_Docente1 = Convert.ToInt16(objDocente.IdDocente);
                objDocenteBE.Valor_codigo = Convert.ToInt16(objDocente.ValorCodigo);
                objDocenteBE.Codigo = objDocente.Codigo;
                objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                objDocenteBE.Nombres = objDocente.Nombres;
                objDocenteBE.Apellidos = objDocente.Apellidos;
                objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                objDocenteBE.Sexo = objDocente.Sexo;
                objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                objDocenteBE.Ciudad = objDocente.Ciudad;
                objDocenteBE.Direccion1 = objDocente.Direccion;
                objDocenteBE.Email = objDocente.Email;
                objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaRegistro);
                objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);
                return objDocenteBE;

            }


            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<DocenteBE> BuscarDocentes(String ape)
        {
            BDCOLEGIOEntities bdcolegio = new BDCOLEGIOEntities();
            try
            {
                List<DocenteBE> objListaDocente = new List<DocenteBE>();
                var query = bdcolegio.sp_filtroDocente(ape);

                foreach (var objDocente in query)
                {

                    DocenteBE objDocenteBE = new DocenteBE();

                    objDocenteBE.Id_Docente1 = objDocente.IdDocente;
                    objDocenteBE.Nombres = objDocente.Nombres;
                    objDocenteBE.Apellidos = objDocente.Apellidos;
                    objDocenteBE.DNI1 = objDocente.DocumentoIdentidad;
                    objDocenteBE.FechaNac = Convert.ToDateTime(objDocente.FechaNacimiento);
                    objDocenteBE.Fecha_regi = Convert.ToDateTime(objDocente.FechaRegistro);
                    objDocenteBE.Sexo = objDocente.Sexo;
                    objDocenteBE.Ciudad = objDocente.Ciudad;
                    objDocenteBE.Grado_estudio = objDocente.GradoEstudio;
                    objDocenteBE.Direccion1 = objDocente.Direccion;
                    objDocenteBE.Email = objDocente.Email;
                    objDocenteBE.Numero_tel1 = objDocente.NumeroTelefono;
                    objDocenteBE.Codigo = objDocente.Codigo;
                    objDocenteBE.Valor_codigo = Convert.ToInt32(objDocente.ValorCodigo);
                    objDocenteBE.Id_Curso1 = Convert.ToInt32(objDocente.IdCurso);


                    objListaDocente.Add(objDocenteBE);




                }
                return objListaDocente;
            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
