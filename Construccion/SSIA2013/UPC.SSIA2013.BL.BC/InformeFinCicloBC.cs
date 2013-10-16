﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.SSIA2013.DL.DALC;
using UPC.SSIA2013.DL.DataModel;

namespace UPC.SSIA2013.BL.BC
{
    public class InformeFinCicloBC
    {
        public up_IFCDC_Obtener_InformeFinCicloResult obtenerInformeFinCiclo(String coordinadorId, int cursoId, int periodoId)
        {
            InformeFinCicloDALC objInformeFinCicloDALC;

            try
            {
                objInformeFinCicloDALC = new InformeFinCicloDALC();
                return objInformeFinCicloDALC.obtenerInformeFinCiclo(coordinadorId, cursoId, periodoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_IFCDC_Editar_InformFinCicloResult editarInformeFinCiclo(int informeFinCicloId, String estado, String unidades, String infraestructura, String alumnos, String delegados, String encuesta)
        {
            InformeFinCicloDALC objInformeFinCicloDALC;

            try
            {
                objInformeFinCicloDALC = new InformeFinCicloDALC();
                return objInformeFinCicloDALC.editarInformeFinCiclo(informeFinCicloId, estado, unidades, infraestructura, alumnos, delegados, encuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public up_IFCDC_Obtener_InformeFinCiclo_x_IdResult obtenerInformeFinCicloxId(int informeFinCicloId)
        {
            InformeFinCicloDALC objInformeFinCicloDALC;

            try
            {
                objInformeFinCicloDALC = new InformeFinCicloDALC();
                return objInformeFinCicloDALC.obtenerInformeFinCicloxId(informeFinCicloId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<up_IFCDC_Listar_Reporte_InformeFinCicloResult> listarReporteInformeFinCiclo(int cursoId, int periodoId, String estado)
        {
            InformeFinCicloDALC objInformeFinCicloDALC;

            try
            {
                objInformeFinCicloDALC = new InformeFinCicloDALC();
                return objInformeFinCicloDALC.listarReporteInformeInformeFinCiclo(cursoId, periodoId, estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
