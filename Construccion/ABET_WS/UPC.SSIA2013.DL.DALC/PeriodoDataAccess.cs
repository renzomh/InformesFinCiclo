using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.DataAccess
{
    public class PeriodoDataAccess
    {


        #region METODOS SIGERCOV
        public List<PeriodoEntity> ListarPeriodoPorCarreraId(int CarreraId)
        {
            List<PeriodoEntity> lista = new List<PeriodoEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[uspListarPeriodosXCarreraId]";
            cmd.CommandType = CommandType.StoredProcedure;

            PeriodoEntity item = null;

            SQLHelper.AddParam(ref cmd, "@CarreraId", ParameterDirection.Input, SqlDbType.Int, CarreraId);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new PeriodoEntity();

                    item.PeriodoId = dr.GetInt32(dr.GetOrdinal("PeriodoId"));
                    item.PeriodoNombre = dr.GetString(dr.GetOrdinal("PeriodoNombre")).ToString();
                    lista.Add(item);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Dispose();
                cmd.Dispose();
                cn = null;
                cmd = null;

            }
            return lista;
        }

        public PeriodoEntity ObtenerPeriodoActual()
        {
            List<PeriodoEntity> lista = new List<PeriodoEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[DevolverPeriodoActual]";
            cmd.CommandType = CommandType.StoredProcedure;

            PeriodoEntity item = null;

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new PeriodoEntity();

                    item.PeriodoNombre = dr.GetString(dr.GetOrdinal("DescripcionPeriodo")).ToString();
                    lista.Add(item);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Dispose();
                cmd.Dispose();
                cn = null;
                cmd = null;

            }
            return lista.First();
        }
        #endregion

        #region METODOS IFC-DC

        public List<up_Listar_PeriodosResult> listarPeriodos()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<up_Listar_PeriodosResult> lstPeriodos = dataContext.up_Listar_Periodos().ToList();

                return lstPeriodos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }

        public up_Obtener_PeriodoActualResult obtenerPeriodoActual()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Obtener_PeriodoActualResult periodo = dataContext.up_Obtener_PeriodoActual().SingleOrDefault();

                return periodo;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (dataContext != null)
                {
                    dataContext.Dispose();
                }
            }
        }
        #endregion


        #region metodosGPPP
        public List<uspPeriodo_ListarXEstadoXEsActualResult> periodoListarXEstadoXEsActual(int? estado, int? esActual)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspPeriodo_ListarXEstadoXEsActualResult> lst = dc.uspPeriodo_ListarXEstadoXEsActual(estado, esActual).ToList();
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
