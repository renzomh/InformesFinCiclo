using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataModel;
using System.Configuration;

namespace UPC.SSIA2013.DataAccess
{
    public class InformeFinCicloDataAccess
    {

        public up_Obtener_InformeFinCicloResult obtenerInformeFinCiclo(String coordinadorID, int cursoId, int periodoId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Obtener_InformeFinCicloResult informeFinCiclo = dataContext.up_Obtener_InformeFinCiclo(coordinadorID, cursoId, periodoId).SingleOrDefault();

                return informeFinCiclo;
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

        public up_Obtener_InformeFinCiclo_x_IdResult obtenerInformeFinCicloxId(int informeFinCicloId)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Obtener_InformeFinCiclo_x_IdResult informeFinCiclo = dataContext.up_Obtener_InformeFinCiclo_x_Id(informeFinCicloId).SingleOrDefault();

                return informeFinCiclo;
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

        public List<up_Listar_Reporte_InformeFinCicloResult> listarReporteInformeInformeFinCiclo(int cursoId, int periodoId, String estado)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<up_Listar_Reporte_InformeFinCicloResult> lstInformes = dataContext.up_Listar_Reporte_InformeFinCiclo(cursoId, periodoId, estado).ToList();

                return lstInformes;
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

        public up_Editar_InformeFinCicloResult editarInformeFinCiclo(int informeFinCicloId, String estado, String unidades, String infraestructura, String alumnos, String delegados, String encuesta)
        {
            SSIA2013DataContext dataContext = null;

            try
            {
                dataContext = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                up_Editar_InformeFinCicloResult informeFinCiclo = dataContext.up_Editar_InformeFinCiclo(informeFinCicloId, estado, unidades, infraestructura, alumnos, delegados, encuesta).SingleOrDefault();

                return informeFinCiclo;
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
    }
}
