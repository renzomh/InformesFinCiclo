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
    public class AlumnoTL
    {
        #region metodos GPPP
        public static AlumnoCollectionDC TranslateAlumnoXAlumnoXCarreraXPeriodoXPPPXEstadoToAlumnoCollectionDC(List<uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult> objLR)
        {
            AlumnoCollectionDC collection;

            try
            {
                collection = new AlumnoCollectionDC();
                collection.lstAlumno = new Collection<AlumnoDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.lstAlumno.Add(TranslateAlumnoXAlumnoXCarreraXPeriodoXPPPXEstadoToAlumnoDC(objLR[i]));
                }

                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static AlumnoDC TranslateAlumnoXAlumnoXCarreraXPeriodoXPPPXEstadoToAlumnoDC(uspAlumno_ListarXAlumnoXCarreraXPeriodoXPPPXEstadoResult objLR)
        {
            AlumnoDC objDC;

            try
            {
                objDC = new AlumnoDC();

                objDC.AlumnoId = objLR.AlumnoId;
                objDC.Nombres = objLR.NOMBRES == null ? "" : objLR.NOMBRES;
                objDC.Apellidos = objLR.APELLIDOS == null ? "" : objLR.APELLIDOS;
                objDC.CarreraId = objLR.CARRERAID == null ? 0 : objLR.CARRERAID;
                objDC.CarreraNombre = objLR.CarreraNombre == null ? "" : objLR.CarreraNombre;
                objDC.PeriodoId = objLR.PERIODOID == null ? 0 : objLR.PERIODOID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.PracticaPreProfesionalId = objLR.PRACTICAPREPROFESIONALID;
                objDC.PPPNombre = objLR.PPPNombre == null ? "" : objLR.PPPNombre;
                objDC.CreditosAprobados = objLR.CREDITOSAPROBADOS == null ? 0 : objLR.CREDITOSAPROBADOS;
                objDC.CreditosPPPCumplidos = objLR.CREDITOSPPPCUMPLIDOS == null ? 0 : objLR.CREDITOSPPPCUMPLIDOS;

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }
        #endregion
    }
}
