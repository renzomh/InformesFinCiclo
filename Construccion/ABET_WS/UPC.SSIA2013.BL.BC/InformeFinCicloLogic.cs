using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.DataModel;

namespace UPC.SSIA2013.BusinessLogic
{
    public class InformeFinCicloLogic
    {

        public up_Obtener_InformeFinCicloResult obtenerInformeFinCiclo(String coordinadorId, int cursoId, int periodoId)
        {
            InformeFinCicloDataAccess objInformeFinCicloDataAccess;

            try
            {
                objInformeFinCicloDataAccess = new InformeFinCicloDataAccess();
                return objInformeFinCicloDataAccess.obtenerInformeFinCiclo(coordinadorId, cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_Editar_InformeFinCicloResult editarInformeFinCiclo(int informeFinCicloId, String estado, String unidades, String infraestructura, String alumnos, String delegados, String encuesta)
        {
            InformeFinCicloDataAccess objInformeFinCicloDataAccess;

            try
            {
                objInformeFinCicloDataAccess = new InformeFinCicloDataAccess();
                return objInformeFinCicloDataAccess.editarInformeFinCiclo(informeFinCicloId, estado, unidades, infraestructura, alumnos, delegados, encuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_Obtener_InformeFinCiclo_x_IdResult obtenerInformeFinCicloxId(int informeFinCicloId)
        {
            InformeFinCicloDataAccess objInformeFinCicloDataAccess;

            try
            {
                objInformeFinCicloDataAccess = new InformeFinCicloDataAccess();
                return objInformeFinCicloDataAccess.obtenerInformeFinCicloxId(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_Listar_Reporte_InformeFinCicloResult> listarReporteInformeFinCiclo(int cursoId, int periodoId, String estado)
        {
            InformeFinCicloDataAccess objInformeFinCicloDataAccess;

            try
            {
                objInformeFinCicloDataAccess = new InformeFinCicloDataAccess();
                return objInformeFinCicloDataAccess.listarReporteInformeInformeFinCiclo(cursoId, periodoId, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
