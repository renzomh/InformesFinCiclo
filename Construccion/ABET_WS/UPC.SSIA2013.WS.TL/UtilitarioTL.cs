using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class UtilitarioTL
    {
        #region metodos GPPP
        public static String ConvertDateToString(DateTime? fecha)
        {
            //return fecha.Value.Day + "/" + fecha.Value.Month + "/" + fecha.Value.Year + " " + fecha.Value.Hour + ":" + fecha.Value.Minute + ":" + fecha.Value.Second;
            Int32 Dia = fecha.Value.Day;
            Int32 Mes = fecha.Value.Month;

            String DiaString = "";
            String MesString = "";

            if (Dia > 0 && Dia < 10)
            {
                DiaString = "0" + Dia.ToString();
            }
            else
            {
                DiaString = Dia.ToString();
            }

            if (Mes > 0 && Mes < 10)
            {
                MesString = "0" + Mes.ToString();
            }
            else
            {
                MesString = Mes.ToString();
            }

            return DiaString + "/" + MesString + "/" + fecha.Value.Year;
        }
        #endregion
    }
}
