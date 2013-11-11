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
    public class EmpresaDataAccess
    {
        #region metodos GPPP
        public List<uspEmpresa_ListarXRazonSocialXRucResult> Empresa_ListarXRazonSocialXRUC(String RazonSocial, String RUC)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspEmpresa_ListarXRazonSocialXRucResult> lst = dc.uspEmpresa_ListarXRazonSocialXRuc(RazonSocial, RUC).ToList();
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

        public Int32 Empresa_Registrar(EmpresaDC objDC)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                Int32 lst = dc.uspEmpresa_Registrar(objDC.RUC, objDC.RazonSocial, objDC.Direccion, objDC.Estado);
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
        #endregion
    }
}
