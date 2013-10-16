﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using UPC.SSIA2013.SI.DataContracts;

namespace UPC.SSIA2013.SI.ServiceContracts
{
    [ServiceContract]
    public interface SSIA2013ServiceContracts
    {
        #region metodos IFC-DC

        [OperationContract]
        ResultadoProgramaxCursoCollectionDC WSListarResultadoProgramaxCurso(ResultadoProgramaxCursoDC objResultadoProgramaDC);

        [OperationContract]
        CursoxProfesorCollectionDC WSListarCursosxProfesor(CursoxProfesorDC objCursoxProfesorDC);

        [OperationContract]
        LogroDC WSListarLogroxCurso(LogroDC objLogroDC);
    
        /*
        [OperationContract]
        ProfesorDC WSObtenerProfesor(ProfesorDC objProfesorDC);
        */
        
        [OperationContract]
        InformeFinCicloDC WSObtenerInformeFinCicloxId(InformeFinCicloDC objInformeFinCicloDC);
        
        [OperationContract]
        InformeFinCicloDC WSObtenerInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC);

        [OperationContract]
        InformeFinCicloDC WSEditarInformeFinCiclo(InformeFinCicloDC objInformeFinCicloDC);

        [OperationContract]
        InformeFinCicloReporteCollectionDC WSListarInformeFinCicloReporte(InformeFinCicloDC objInformeFinCicloDC);

        //HALLAZGOS
        [OperationContract]
        HallazgoCollectionDC WSRegistrarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSListarHallazgosxInformeFinCiclo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSEditarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoCollectionDC WSEliminarHallazgo(HallazgoDC objHallazgoDC);

        [OperationContract]
        HallazgoReporteCollectionDC WSListarHallazgoReporte(InformeFinCicloDC objInformeFinCicloDC);

        //ACCIONES DE MEJORA

        [OperationContract]
        AccionMejoraCollectionDC WSRegistrarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC  WSListarAccionesMejoraxInformeFinCiclo(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSListarAccionesMejoraPrevias(InformeFinCicloDC informeFinCicloDC);

        [OperationContract]
        AccionMejoraCollectionDC WSEditarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        //[OperationContract]
        //AccionMejoraCollectionDC WSEditarAccionMejoraPrevia(InformeFinCicloDC informeFinCicloDc, AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraCollectionDC WSEliminarAccionMejora(AccionMejoraDC objAccionMejoraDC);

        [OperationContract]
        AccionMejoraReporteCollectionDC WSListarAccionMejoraReporte(InformeFinCicloDC objInformeFinCicloDC);

        //PERSONA
        [OperationContract]
        PersonaDC WSObtenerPersona(PersonaDC objPersonaDC);

        //PERIODO
        [OperationContract]
        PeriodoCollectionDC WSListarPeriodos();

        [OperationContract]
        PeriodoDC WSObtenerPeriodoActual();

        //CURSO
        [OperationContract]
        CursoCollectionDC WSListarCursos();

        #endregion
    }
}
