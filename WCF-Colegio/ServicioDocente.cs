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
                DOCENTE objDocente = new DOCENTE();

                objDocente.Nombres = objDocenteBE.Nombres;
                objDocente.ValorCodigo = objDocenteBE.Valor_codigo;
                objDocente.DocumentoIdentidad = objDocenteBE.DNI1;
                objDocente.Apellidos = objDocenteBE.Apellidos;
                objDocente.FechaNacimiento = objDocenteBE.FechaNac;
                objDocente.Sexo = objDocenteBE.Sexo;
                objDocente.GradoEstudio = objDocenteBE.Grado_estudio;
                objDocente.Ciudad = objDocenteBE.Ciudad;
                objDocente.Direccion = objDocenteBE.Direccion1;
                objDocente.Email = objDocenteBE.Email;
                objDocente.NumeroTelefono = objDocenteBE.Numero_tel1;
                objDocente.FechaRegistro = objDocenteBE.Fecha_regi;




                //Agregamos la isntancia de nuevo docente a su clase
                bdcolegio.DOCENTE.Add(objDocente);

                //Refrescamos la bd
                bdcolegio.SaveChanges();
                return true;

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

                DOCENTE objDocente = (

                    from oDocente in bdcolegio.DOCENTE
                    where oDocente.IdDocente == objDocenteBE.Id_Docente1
                    select oDocente).FirstOrDefault();

                objDocente.IdDocente = objDocenteBE.Id_Docente1;
                objDocente.Codigo = objDocenteBE.Codigo;
                objDocente.ValorCodigo = objDocenteBE.Valor_codigo;
                objDocente.Nombres = objDocenteBE.Nombres;
                objDocente.Apellidos = objDocenteBE.Apellidos;
                objDocente.Direccion = objDocenteBE.Direccion1;
                objDocente.Sexo = objDocenteBE.Sexo;
                objDocente.DocumentoIdentidad = objDocenteBE.DNI1;
                objDocente.FechaNacimiento = objDocenteBE.FechaNac;
                objDocente.FechaRegistro = objDocenteBE.Fecha_regi;
                objDocente.NumeroTelefono = objDocenteBE.Numero_tel1;
                objDocente.Email = objDocenteBE.Email;


                bdcolegio.SaveChanges();

                return true;




            }
            catch (EntityException ex)
            {

                throw new Exception(ex.Message);
            }


        }
    }
}
