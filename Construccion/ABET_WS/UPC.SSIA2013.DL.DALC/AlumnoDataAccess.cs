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
    public class AlumnoDataAccess
    {
        #region metodos GPPP
        public List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult> alumnoListarXAlumnoXCarreraXPeriodoXPPPXEstado(String AlumnoId, Int32? CarreraId, Int32? PeriodoId, Int32 PracticaPreProfesionalId, Int32? Estado, Boolean busqueda)
        {
            SSIA2013DataContext dc = null;
            try
            {
                dc = new SSIA2013DataContext(ConfigurationManager.ConnectionStrings["SSIA2013"].ToString());
                List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult> lst;
                if (busqueda)
                {
                    lst = dc.uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstado(AlumnoId, CarreraId, PeriodoId, PracticaPreProfesionalId, Estado).ToList();
                }
                else
                {
                    List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstado_SinMatriculaResult> lstn = dc.uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstado_SinMatricula(AlumnoId, CarreraId, PeriodoId, PracticaPreProfesionalId, Estado).ToList();
                    lst = new List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult>();
                    for(int i=0;i<lstn.Count;i++)
                    {
                        uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult rst = new uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult();
                        rst.AlumnoId = lstn.ElementAt(i).AlumnoId;
                        rst.APELLIDOS = lstn.ElementAt(i).APELLIDOS;
                        rst.CARRERAID = lstn.ElementAt(i).CARRERAID;
                        rst.CarreraNombre = lstn.ElementAt(i).CarreraNombre;
                        rst.CREDITOSAPROBADOS = lstn.ElementAt(i).CREDITOSAPROBADOS;
                        rst.CREDITOSPPPCUMPLIDOS = lstn.ElementAt(i).CREDITOSPPPCUMPLIDOS;
                        rst.DESCRIPCION = lstn.ElementAt(i).DESCRIPCION;
                        rst.NOMBRES = lstn.ElementAt(i).NOMBRES;
                        rst.PERIODOID = lstn.ElementAt(i).PERIODOID;
                        rst.PPPNombre = lstn.ElementAt(i).PPPNombre;
                        rst.PRACTICAPREPROFESIONALID = lstn.ElementAt(i).PRACTICAPREPROFESIONALID;
                        lst.Add(rst);
                    }
                }
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
