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
    public class CursoTL
    {


        #region METODO SIGERCOV

        public static CursoEntity CursoDCConvertirCursoBE(CursoDC oCursoDC)
        {
            try
            {
                CursoEntity oCursoBE = new CursoEntity();
                oCursoBE.CursoId = oCursoDC.CursoId;
                oCursoBE.CursoNombre = oCursoDC.Nombre;
                oCursoBE.CursoControl = oCursoDC.CursoControl;
                oCursoBE.CursoCreditos = oCursoDC.CursoCreditos;
                oCursoBE.CursoVerificacion = oCursoDC.CursoVerificacion;
                return oCursoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoDC CursoBEConvertirCursoDC(CursoEntity oCursoBE)
        {
            try
            {
                CursoDC oCursoDC = new CursoDC();
                oCursoDC.CursoId = oCursoBE.CursoId;
                oCursoDC.Nombre = oCursoBE.CursoNombre;
                oCursoDC.CursoControl = oCursoBE.CursoControl;
                oCursoDC.CursoCreditos = oCursoBE.CursoCreditos;
                oCursoDC.CursoVerificacion = oCursoBE.CursoVerificacion;
                return oCursoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoCollectionDC CursoCollectionBEConvertirCursoCollectionDC(List<CursoEntity> listCursoBE)
        {
            CursoCollectionDC oCursoCollectionDC = new CursoCollectionDC();
            CursoDC oCursoDC;
            for (int i = 0; i < listCursoBE.Count; i++)
            {
                oCursoDC = CursoBEConvertirCursoDC(listCursoBE[i]);
                oCursoCollectionDC.Add(oCursoDC);
            }

            return oCursoCollectionDC;
        }

        #endregion

        #region METODO IFCDC

        public static CursoCollectionDC TranslateListarCursosLRToCursoCollectionDC(List<up_Listar_CursosResult> lstLR)
        {
            CursoCollectionDC collection;

            try
            {
                collection = new CursoCollectionDC();

                for (int i = 0; i < lstLR.Count; i++)
                    collection.Add(TranslateListarCursosLRToCursoDC(lstLR[i]));

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoDC TranslateListarCursosLRToCursoDC(up_Listar_CursosResult objLR)
        {
            CursoDC objCursoDC;

            try
            {
                objCursoDC = new CursoDC();
                if (objLR != null)
                {
                    objCursoDC.CursoId = Convert.ToInt32(objLR.CursoId);
                    objCursoDC.Codigo = objLR.Codigo;
                    objCursoDC.Nombre = objLR.Nombre;
                }
                return objCursoDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoxProfesorCollectionDC TranslateCursosxProfesorLRToCursosxProfesorCollection(List<up_Listar_Cursos_x_ProfesorResult> lstLR)
        {
            CursoxProfesorCollectionDC collection;

            try
            {
                collection = new CursoxProfesorCollectionDC();
                collection.LstCursosxProfesor = new Collection<CursoxProfesorDC>();

                for (int i = 0; i < lstLR.Count; i++)
                {
                    collection.LstCursosxProfesor.Add(TranslateCursoxProfesorLRToCursoxProfesorDC(lstLR[i]));
                }

                return collection;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static CursoxProfesorDC TranslateCursoxProfesorLRToCursoxProfesorDC(up_Listar_Cursos_x_ProfesorResult objLR)
        {
            CursoxProfesorDC objCursoxProfesorDC;

            try
            {
                objCursoxProfesorDC = new CursoxProfesorDC();

                objCursoxProfesorDC.CursoId = objLR.CursoId;
                objCursoxProfesorDC.Codigo = objLR.Codigo;
                objCursoxProfesorDC.Nombre = objLR.Nombre;
                objCursoxProfesorDC.ProfesorId = objLR.ProfesorId;

                return objCursoxProfesorDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


    }
}
