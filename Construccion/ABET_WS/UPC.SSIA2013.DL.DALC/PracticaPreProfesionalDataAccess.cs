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
    public class PracticaPreProfesionalDataAccess
    {
        #region metodosGPPP
        public List<uspPractica_ListarXPeriodoXCarreraXEstadoResult> practicaPreProfesionalListarXPeriodoXCarreraXEstado(Int32 PeriodoId, Int32 CarreraId, Int32? Estado)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspPractica_ListarXPeriodoXCarreraXEstadoResult> lst = dc.uspPractica_ListarXPeriodoXCarreraXEstado(PeriodoId, CarreraId, Estado).ToList();
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

        public int practicaPreProfesionalInsertar(PracticaPreProfesionalDC objDC)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int lst = dc.uspPractica_Registrar(objDC.CarreraId, objDC.PeriodoId, objDC.Numero, objDC.Nombre, objDC.NombreInforme, objDC.CreditosACumplirInicio, objDC.CreditosACumplirFin, objDC.MinimoCreditosInicio, objDC.MinimoCreditosFin, objDC.CreditosACumplirMaximo);
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

        public int practicaPreProfesionalActualizar(PracticaPreProfesionalDC objDC)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                int lst = dc.uspPractica_Actualizar(objDC.PracticaPreProfesionalId, objDC.PeriodoId, objDC.Numero, objDC.Nombre, objDC.NombreInforme, objDC.CreditosACumplirInicio, objDC.CreditosACumplirFin, objDC.MinimoCreditosInicio, objDC.MinimoCreditosFin, objDC.CreditosACumplirMaximo);
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
