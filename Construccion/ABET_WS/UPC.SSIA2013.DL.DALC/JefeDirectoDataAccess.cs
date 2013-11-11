using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Configuration;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.DataAccess
{
    public class JefeDirectoDataAccess
    {
        #region metodos GPPP
        public List<uspJefeDirecto_ListarXNombreXApellidoXDNIResult> JefeDirecto_ListarXNombreXApellidoXDNI(String Nombre, String Apellidos, String DNI)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspJefeDirecto_ListarXNombreXApellidoXDNIResult> lst = dc.uspJefeDirecto_ListarXNombreXApellidoXDNI(Nombre, Apellidos, DNI).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }

        public Int32 JefeDirecto_Registrar(JefeDirecto2DC objDC)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int correcto = dc.uspJefeDirecto_Registrar(objDC.JefeDirectoId, objDC.Nombres, objDC.Apellidos, objDC.NroDocumento, objDC.Telefono1, objDC.Cargo, objDC.Anexo, objDC.Estado); // 1=correcto -1=incorrecto
                return correcto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dc != null)
                {
                    dc.Dispose();
                }
            }
        }
        #endregion                 
    }
}
