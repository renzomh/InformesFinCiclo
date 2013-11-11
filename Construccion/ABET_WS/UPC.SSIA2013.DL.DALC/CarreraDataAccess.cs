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
    public class CarreraDataAccess
    {
        public List<CarreraEntity> ListarCarreras()
        {
            List<CarreraEntity> lista = new List<CarreraEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[uspListarCarreras]";
            cmd.CommandType = CommandType.StoredProcedure;

            CarreraEntity item = null;

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new CarreraEntity();

                    item.CarreraId = dr.GetInt32(dr.GetOrdinal("CarreraId"));
                    item.CarreraNombre = dr.GetString(dr.GetOrdinal("CarreraNombre")).ToString();
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

        #region metodos GPPP
        public List<uspCarrera_ListarXEscuelaResult> carreraListarXEscuela(Int32? escuelaId)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspCarrera_ListarXEscuelaResult> lst = dc.uspCarrera_ListarXEscuela(escuelaId).ToList();
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
