using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class LogroTL
    {
        #region METODO IFCDC

        public static LogroDC TranslateLogroLRToLogroDC(up_Obtener_Logro_x_CursoResult objLR)
        {
            LogroDC objLogroDC;

            try
            {
                objLogroDC = new LogroDC();

                if (objLR != null)
                {
                    objLogroDC.LogroId = objLR.LogroId;
                    objLogroDC.CursoId = objLR.CursoId;
                    objLogroDC.Descripcion = objLR.Descripcion;
                    objLogroDC.Estado = Boolean.Parse(objLR.Estado.ToString());
                }

                return objLogroDC;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
