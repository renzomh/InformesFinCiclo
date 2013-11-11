using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.DataAccess
{
    public class CursoDataAccess
    {
        #region METODOS SIGERCOV

        public List<CursoEntity> ListarCursosPorTipoCursoCarreraId(int? CarreraId, int? TipoCurso)
        {
            List<CursoEntity> lista = new List<CursoEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[uspListarCursosPorTipoCursoCarreraId]";
            cmd.CommandType = CommandType.StoredProcedure;

            CursoEntity item = null;

            SQLHelper.AddParam(ref cmd, "@CarreraId", ParameterDirection.Input, SqlDbType.Int, CarreraId);
            SQLHelper.AddParam(ref cmd, "@TipoCurso", ParameterDirection.Input, SqlDbType.Int, TipoCurso);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new CursoEntity();

                    item.CursoId = dr.GetInt32(dr.GetOrdinal("CursoId"));
                    item.CursoNombre = dr.GetString(dr.GetOrdinal("CursoNombre")).ToString();
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

        public List<CursoEntity> ListarCursosPorCarreraPorNivelPorPeriodoActual(int? carreraId, int? nivel)
        {
            List<CursoEntity> lista = new List<CursoEntity>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[ListarCursoXCarreraXNivelXPeriodoActual]";
            cmd.CommandType = CommandType.StoredProcedure;

            CursoEntity item = null;

            SQLHelper.AddParam(ref cmd, "@CarreraId", ParameterDirection.Input, SqlDbType.Int, carreraId);
            SQLHelper.AddParam(ref cmd, "@Nivel", ParameterDirection.Input, SqlDbType.Int, nivel);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    item = new CursoEntity();

                    item.CursoId = dr.GetInt32(dr.GetOrdinal("CursoId"));
                    item.CursoNombre = dr.GetString(dr.GetOrdinal("Nombre")).ToString();

                    item.CursoControl = Convert.ToBoolean(dr.GetInt32(dr.GetOrdinal("EsControl")));
                    item.CursoVerificacion = Convert.ToBoolean(dr.GetInt32(dr.GetOrdinal("EsVerificacion")));
                    item.CursoCreditos = dr.GetInt32(dr.GetOrdinal("Creditos"));

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

        public void ActualizarCursosPorCarreraPorNivelPorPeriodoActual(int? cursoId, bool esControl, bool esVerificacion)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "[SIGERCOV].[uspActualizarCurso]";
            cmd.CommandType = CommandType.StoredProcedure;

            SQLHelper.AddParam(ref cmd, "@CursoId", ParameterDirection.Input, SqlDbType.Int, cursoId);
            SQLHelper.AddParam(ref cmd, "@EsControl", ParameterDirection.Input, SqlDbType.Bit, esControl);
            SQLHelper.AddParam(ref cmd, "@EsVerificacion", ParameterDirection.Input, SqlDbType.Bit, esVerificacion);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
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
        }

        #endregion

        #region METODOS IFC-DC
        public List<up_Listar_CursosResult> listarCursos()
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<up_Listar_CursosResult> lstCursos = dataContext.up_Listar_Cursos().ToList();

                return lstCursos;
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

        public List<up_Listar_Cursos_x_ProfesorResult> listarCursosxProfesor(string profesorId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<up_Listar_Cursos_x_ProfesorResult> lstCursosxProfesor = dataContext.up_Listar_Cursos_x_Profesor(profesorId).ToList();

                return lstCursosxProfesor;
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

    }
}
