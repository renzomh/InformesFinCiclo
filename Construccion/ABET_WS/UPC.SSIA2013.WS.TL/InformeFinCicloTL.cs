using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class InformeFinCicloTL
    {
        #region METODO IFCDC

        public static InformeFinCicloDC TranslateInformeFinCicloxIdLRToInformeFinCicloDC(up_Obtener_InformeFinCiclo_x_IdResult objLR)
        {
            InformeFinCicloDC objInformeFinCiclo;

            try
            {
                objInformeFinCiclo = new InformeFinCicloDC();

                if (objLR != null)
                {
                    objInformeFinCiclo.InformeFinCicloId = objLR.InformeFinCicloId;
                    objInformeFinCiclo.CoordinadorId = objLR.CoordinadorId;
                    objInformeFinCiclo.CursoId = objLR.CursoId;
                    objInformeFinCiclo.PeriodoId = objLR.PeriodoId;
                    objInformeFinCiclo.DesarrolloUnidades = objLR.DesarrolloUnidades;
                    objInformeFinCiclo.ComentarioInfraestructura = objLR.ComentarioInfraestructura;
                    objInformeFinCiclo.ComentarioAlumnos = objLR.ComentarioAlumnos;
                    objInformeFinCiclo.ComentarioDelegados = objLR.ComentarioDelegados;
                    objInformeFinCiclo.ComentarioEncuesta = objLR.ComentarioEscuesta;
                    objInformeFinCiclo.UltimaActualizacion = objLR.UltimaActualizacion;
                    objInformeFinCiclo.Estado = objLR.Estado;
                }

                return objInformeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static InformeFinCicloDC TranslateInformeFinCicloLRToInformeFinCicloDC(up_Obtener_InformeFinCicloResult objLR)
        {
            InformeFinCicloDC objInformeFinCiclo;

            try
            {
                objInformeFinCiclo = new InformeFinCicloDC();

                if (objLR != null)
                {
                    objInformeFinCiclo.InformeFinCicloId = objLR.InformeFinCicloId;
                    objInformeFinCiclo.CoordinadorId = objLR.CoordinadorId;
                    objInformeFinCiclo.CursoId = objLR.CursoId;
                    objInformeFinCiclo.PeriodoId = objLR.PeriodoId;
                    objInformeFinCiclo.DesarrolloUnidades = objLR.DesarrolloUnidades;
                    objInformeFinCiclo.ComentarioInfraestructura = objLR.ComentarioInfraestructura;
                    objInformeFinCiclo.ComentarioAlumnos = objLR.ComentarioAlumnos;
                    objInformeFinCiclo.ComentarioDelegados = objLR.ComentarioDelegados;
                    objInformeFinCiclo.ComentarioEncuesta = objLR.ComentarioEscuesta;
                    objInformeFinCiclo.UltimaActualizacion = objLR.UltimaActualizacion;
                    objInformeFinCiclo.Estado = objLR.Estado;
                }

                return objInformeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static InformeFinCicloDC TranslateEditarInformeFinCicloLRToInformeFinCicloDC(up_Editar_InformeFinCicloResult objLR)
        {
            InformeFinCicloDC objInformeFinCiclo;

            try
            {
                objInformeFinCiclo = new InformeFinCicloDC();

                if (objLR != null)
                {
                    objInformeFinCiclo.InformeFinCicloId = objLR.InformeFinCicloId;
                    objInformeFinCiclo.CoordinadorId = objLR.CoordinadorId;
                    objInformeFinCiclo.CursoId = objLR.CursoId;
                    objInformeFinCiclo.PeriodoId = objLR.PeriodoId;
                    objInformeFinCiclo.DesarrolloUnidades = objLR.DesarrolloUnidades;
                    objInformeFinCiclo.ComentarioInfraestructura = objLR.ComentarioInfraestructura;
                    objInformeFinCiclo.ComentarioAlumnos = objLR.ComentarioAlumnos;
                    objInformeFinCiclo.ComentarioDelegados = objLR.ComentarioDelegados;
                    objInformeFinCiclo.ComentarioEncuesta = objLR.ComentarioEscuesta;
                    objInformeFinCiclo.UltimaActualizacion = objLR.UltimaActualizacion;
                    objInformeFinCiclo.Estado = objLR.Estado;
                }

                return objInformeFinCiclo;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static InformeFinCicloReporteCollectionDC TranslateInformeFinCicloReporteLRToInformeFinCicloReporteCollection(List<up_Listar_Reporte_InformeFinCicloResult> lstLR)
        {
            InformeFinCicloReporteCollectionDC collection;

            try
            {
                collection = new InformeFinCicloReporteCollectionDC();
                collection.LstInformeFinCicloReporte = new Collection<InformeFinCicloReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstInformeFinCicloReporte.Add(TranslateInformeFinCicloReporteLRToInformeFinCicloReporteDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static InformeFinCicloReporteDC TranslateInformeFinCicloReporteLRToInformeFinCicloReporteDC(up_Listar_Reporte_InformeFinCicloResult objLR)
        {
            InformeFinCicloReporteDC obj;

            try
            {
                obj = new InformeFinCicloReporteDC();

                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.NombreCurso = objLR.NombreCurso;
                obj.NombreProfesor = objLR.NombreProfesor;
                obj.CodigoCurso = objLR.CodigoCurso;
                obj.Estado = objLR.Estado;
                obj.FechaActualizacion = objLR.FechaActualizacion;
                obj.Periodo = objLR.Periodo;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
