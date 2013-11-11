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
    public class HallazgoTL
    {
        #region METODO IFCDC


        public static HallazgoCollectionDC TranslateHallazgosRegistrarLRToHallazgosCollection(List<up_Registrar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoRegistrarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoRegistrarLRToHallazgoDC(up_Registrar_HallazgoResult objLR)
        {
            HallazgoDC objHallazgoDC;

            try
            {
                objHallazgoDC = new HallazgoDC();

                objHallazgoDC.HallazgoId = objLR.HallazgoId;
                objHallazgoDC.InformeFinCicloId = objLR.InformeFinCicloId;
                objHallazgoDC.Codigo = objLR.Codigo;
                objHallazgoDC.Descripcion = objLR.Descripcion;

                return objHallazgoDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HallazgoCollectionDC TranslateHallazgosListarLRToHallazgosCollection(List<up_Listar_Hallazgos_x_InformeFinCicloResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoListarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoListarLRToHallazgoDC(up_Listar_Hallazgos_x_InformeFinCicloResult objLR)
        {
            HallazgoDC objHallazgoDC;

            try
            {
                objHallazgoDC = new HallazgoDC();

                objHallazgoDC.HallazgoId = objLR.HallazgoId;
                objHallazgoDC.InformeFinCicloId = objLR.InformeFinCicloId;
                objHallazgoDC.Codigo = objLR.Codigo;
                objHallazgoDC.Descripcion = objLR.Descripcion;

                return objHallazgoDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HallazgoCollectionDC TranslateHallazgosEditarLRToHallazgosCollection(List<up_Editar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoEditarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoEditarLRToHallazgoDC(up_Editar_HallazgoResult objLR)
        {
            HallazgoDC objHallazgoDC;

            try
            {
                objHallazgoDC = new HallazgoDC();

                objHallazgoDC.HallazgoId = objLR.HallazgoId;
                objHallazgoDC.InformeFinCicloId = objLR.InformeFinCicloId;
                objHallazgoDC.Codigo = objLR.Codigo;
                objHallazgoDC.Descripcion = objLR.Descripcion;

                return objHallazgoDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HallazgoCollectionDC TranslateHallazgosEliminarLRToHallazgosCollection(List<up_Eliminar_HallazgoResult> lstLR)
        {
            HallazgoCollectionDC collection;

            try
            {
                collection = new HallazgoCollectionDC();
                collection.LstHallazgos = new Collection<HallazgoDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgos.Add(TranslateHallazgoEliminarLRToHallazgoDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoDC TranslateHallazgoEliminarLRToHallazgoDC(up_Eliminar_HallazgoResult objLR)
        {
            HallazgoDC objHallazgoDC;

            try
            {
                objHallazgoDC = new HallazgoDC();

                objHallazgoDC.HallazgoId = objLR.HallazgoId;
                objHallazgoDC.InformeFinCicloId = objLR.InformeFinCicloId;
                objHallazgoDC.Codigo = objLR.Codigo;
                objHallazgoDC.Descripcion = objLR.Descripcion;

                return objHallazgoDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static HallazgoReporteCollectionDC TranslateHallazgoReporteLRToHallazgoReporteCollection(List<up_Listar_Reporte_HallazgoResult> lstLR)
        {
            HallazgoReporteCollectionDC collection;

            try
            {
                collection = new HallazgoReporteCollectionDC();
                collection.LstHallazgoReporte = new Collection<HallazgoReporteDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstHallazgoReporte.Add(TranslateHallazgoReporteLRToHallazgoReporteDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static HallazgoReporteDC TranslateHallazgoReporteLRToHallazgoReporteDC(up_Listar_Reporte_HallazgoResult objLR)
        {
            HallazgoReporteDC obj;

            try
            {
                obj = new HallazgoReporteDC();

                obj.HallazogId = objLR.HallazgoId;
                obj.CodigoHallazgo = objLR.CodigoHallazgo;
                obj.Descripcion = objLR.Descripcion;
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
