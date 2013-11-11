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

namespace UPC.SSIA2013.DataAccess
{
    public class OutcomeDataAccess
    {
        public List<OutcomeEntity> ListarOutcomePorCarreraId(int CarreraId)
        {
            List<OutcomeEntity> lista = new List<OutcomeEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[uspListarOutcomePorCarreraId]";
            cmd.CommandType = CommandType.StoredProcedure;

            OutcomeEntity item = null;

            SQLHelper.AddParam(ref cmd, "@CarreraId", ParameterDirection.Input, SqlDbType.Int, CarreraId);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new OutcomeEntity();

                    item.OutcomeId = dr.GetInt32(dr.GetOrdinal("OutcomeId"));
                    item.OutcomeNombre = dr.GetString(dr.GetOrdinal("OutcomeNombre")).ToString();
                    item.OutcomeDescripcion = dr.GetString(dr.GetOrdinal("OutcomeDescripcion")).ToString();
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
    }
}
