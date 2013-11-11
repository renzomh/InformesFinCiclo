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
    public class AccionMejoraTL
    {
        #region METODO IFCDC


        public static AccionMejoraCollectionDC TranslateAccionesMejoraRegistrarLRToAccionMejoraCollection(List<up_Registrar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraRegistrarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraRegistrarLRToAccionMejoraDC(up_Registrar_AccionMejoraResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraListarLRToAccionMejoraCollection(List<up_Listar_AccionMejora_x_InformeFinCicloResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraListarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraListarLRToAccionMejoraDC(up_Listar_AccionMejora_x_InformeFinCicloResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesPreviasListarLRToAccionMejoraCollection(List<up_Listar_AccionMejora_PreviasResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraPreviaListarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraPreviaListarLRToAccionMejoraDC(up_Listar_AccionMejora_PreviasResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraEditarLRToAccionMejoraCollection(List<up_Editar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraEditarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraEditarLRToAccionMejoraDC(up_Editar_AccionMejoraResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraPreviaEditarLRToAccionMejoraCollection(List<up_Editar_AccionMejora_PreviaResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraPreviaEditarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraPreviaEditarLRToAccionMejoraDC(up_Editar_AccionMejora_PreviaResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraCollectionDC TranslateAccionesMejoraEliminarLRToAccionMejoraCollection(List<up_Eliminar_AccionMejoraResult> lstLR)
        {
            AccionMejoraCollectionDC collection;

            try
            {
                collection = new AccionMejoraCollectionDC();
                collection.LstAccionesMejora = new Collection<AccionMejoraDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionesMejora.Add(TranslateAccionMejoraEliminarLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraDC TranslateAccionMejoraEliminarLRToAccionMejoraDC(up_Eliminar_AccionMejoraResult objLR)
        {
            AccionMejoraDC obj;

            try
            {
                obj = new AccionMejoraDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.HallazgoId = objLR.HallazgoId;
                obj.InformeFinCicloId = objLR.InformeFinCicloId;
                obj.Codigo = objLR.Codigo;
                obj.Descripcion = objLR.Descripcion;
                obj.CicloEjecucionId = objLR.CicloEjecucionId;
                obj.CicloEjecucion = objLR.CicloEjecucion;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;

                return obj;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AccionMejoraReporteCollectionDC TranslateAccionesMejoraReporteLRToAccionMejoraCollection(List<up_Listar_Reporte_AccionMejoraResult> lstLR)
        {
            AccionMejoraReporteCollectionDC collection;

            try
            {
                collection = new AccionMejoraReporteCollectionDC();
                collection.LstAccionMejoraReporte = new Collection<AccionMejoraReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstAccionMejoraReporte.Add(TranslateAccionMejoraReporteLRToAccionMejoraDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static AccionMejoraReporteDC TranslateAccionMejoraReporteLRToAccionMejoraDC(up_Listar_Reporte_AccionMejoraResult objLR)
        {
            AccionMejoraReporteDC obj;

            try
            {
                obj = new AccionMejoraReporteDC();

                obj.AccionMejoraId = objLR.AccionMejoraId;
                obj.Descripcion = objLR.Descripcion;
                obj.CodigoAccionMejora = objLR.CodigoAccionMejora;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Estado = objLR.Estado;
                obj.NombreCurso = objLR.NombreCurso;

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
