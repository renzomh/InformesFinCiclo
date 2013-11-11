using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.WS.DataContract;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.TranslatorLayer;

using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.TranslatorLayer
{
    public class EncuestaTL
    {
        #region metodos GPPP
        public static EncuestaGrillaCollectionDC TranslateEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistroToEncuestaCollectionDC(List<uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistroResult> objLR)
        {
            EncuestaGrillaCollectionDC collection;

            try
            {
                collection = new EncuestaGrillaCollectionDC();
                collection.LstEncuesta = new Collection<EncuestaGrillaDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.LstEncuesta.Add(TranslateEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistroToEncuestaGrillaDC(objLR[i]));
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

        public static EncuestaGrillaDC TranslateEncuestaXCarreraXPeriodoXPPPXEstadoXTipoRegistroToEncuestaGrillaDC(uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistroResult objLR)
        {
            EncuestaGrillaDC objDC;

            try
            {
                objDC = new EncuestaGrillaDC();

                objDC.EncuestaId = objLR.ENCUESTAID;
                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.CarreraId = objLR.CARRERAID;
                objDC.CARRERA_NOMBRE = objLR.CARRERA_NOMBRE == null ? "" : objLR.CARRERA_NOMBRE;
                objDC.PeriodoId = objLR.PERIODOID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.PracticaPreProfesionalId = objLR.PRACTICAPREPROFESIONALID;
                objDC.PRACTICAPREPROFESIONAL_NOMBRE = objLR.PRACTICAPREPROFESIONAL_NOMBRE == null ? "" : objLR.PRACTICAPREPROFESIONAL_NOMBRE;
                objDC.MALLAENCUESTA_NOMBRE = objLR.MALLAENCUESTA_NOMBRE == null ? "" : objLR.ALUMNO_NOMBRES;
                objDC.MALLAENCUESTA_ESTADO = objLR.MALLAENCUESTA_ESTADO == null ? 0 : objLR.MALLAENCUESTA_ESTADO;
                objDC.ENCUESTA_ESTADO = objLR.ENCUESTA_ESTADO == null ? 0 : objLR.ENCUESTA_ESTADO;
                objDC.EmpresaId = objLR.EMPRESAID;
                objDC.JefeDirectoId = objLR.JEFEDIRECTOID;
                //objDC.PersonaId = objLR.PERSONAID;
                objDC.AlumnoId = objLR.ALUMNOID;
                objDC.ALUMNO_APELLIDOS = objLR.ALUMNO_APELLIDOS == null ? "" : objLR.ALUMNO_APELLIDOS;
                objDC.ALUMNO_NOMBRES = objLR.ALUMNO_NOMBRES == null ? "" : objLR.ALUMNO_NOMBRES;
                objDC.TotalHoras = objLR.TOTALHORAS;
                objDC.TipoRegistro = objLR.TIPOREGISTRO == null ? "" : objLR.TIPOREGISTRO;
                //objDC.JEFEDIRECTO_APELLIDOS = objLR.JEFEDIRECTO_APELLIDOS == null ? "" : objLR.JEFEDIRECTO_APELLIDOS;
                //objDC.JEFEDIRECTO_NOMBRES = objLR.JEFEDIRECTO_NOMBRES == null ? "" : objLR.JEFEDIRECTO_NOMBRES;
                objDC.RazonSocial = objLR.RAZONSOCIAL == null ? "" : objLR.RAZONSOCIAL;
                objDC.FechaRegistroDigital = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRODIGITAL) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRODIGITAL);

                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { }
        }

        public static EncuestaGrillaCollectionDC TranslateEncuestaXFechasToEncuestaCollectionDC(List<uspEncuesta_ListarXFechasResult> objLR)
        {
            EncuestaGrillaCollectionDC collection;

            try
            {
                collection = new EncuestaGrillaCollectionDC();
                collection.LstEncuesta = new Collection<EncuestaGrillaDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.LstEncuesta.Add(TranslateEncuestaXFechasToEncuestaGrillaDC(objLR[i]));
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

        public static EncuestaGrillaDC TranslateEncuestaXFechasToEncuestaGrillaDC(uspEncuesta_ListarXFechasResult objLR)
        {
            EncuestaGrillaDC objDC;

            try
            {
                objDC = new EncuestaGrillaDC();

                objDC.EncuestaId = objLR.ENCUESTAID;
                objDC.MallaEncuestaId = objLR.MALLAENCUESTAID;
                objDC.CarreraId = objLR.CARRERAID;
                objDC.CARRERA_NOMBRE = objLR.CARRERA_NOMBRE == null ? "" : objLR.CARRERA_NOMBRE;
                objDC.PeriodoId = objLR.PERIODOID;
                objDC.Descripcion = objLR.DESCRIPCION == null ? "" : objLR.DESCRIPCION;
                objDC.PracticaPreProfesionalId = objLR.PRACTICAPREPROFESIONALID;
                objDC.PRACTICAPREPROFESIONAL_NOMBRE = objLR.PRACTICAPREPROFESIONAL_NOMBRE == null ? "" : objLR.PRACTICAPREPROFESIONAL_NOMBRE;
                objDC.MALLAENCUESTA_NOMBRE = objLR.MALLAENCUESTA_NOMBRE == null ? "" : objLR.ALUMNO_NOMBRES;
                objDC.MALLAENCUESTA_ESTADO = objLR.MALLAENCUESTA_ESTADO == null ? 0 : objLR.MALLAENCUESTA_ESTADO;
                objDC.ENCUESTA_ESTADO = objLR.ENCUESTA_ESTADO == null ? 0 : objLR.ENCUESTA_ESTADO;
                objDC.EmpresaId = objLR.EMPRESAID;
                objDC.JefeDirectoId = objLR.JEFEDIRECTOID;
                //objDC.PersonaId = objLR.PERSONAID;
                objDC.AlumnoId = objLR.ALUMNOID;
                objDC.ALUMNO_APELLIDOS = objLR.ALUMNO_APELLIDOS == null ? "" : objLR.ALUMNO_APELLIDOS;
                objDC.ALUMNO_NOMBRES = objLR.ALUMNO_NOMBRES == null ? "" : objLR.ALUMNO_NOMBRES;
                objDC.TotalHoras = objLR.TOTALHORAS;
                objDC.TipoRegistro = objLR.TIPOREGISTRO == null ? "" : objLR.TIPOREGISTRO;
                //objDC.JEFEDIRECTO_APELLIDOS = objLR.JEFEDIRECTO_APELLIDOS == null ? "" : objLR.JEFEDIRECTO_APELLIDOS;
                //objDC.JEFEDIRECTO_NOMBRES = objLR.JEFEDIRECTO_NOMBRES == null ? "" : objLR.JEFEDIRECTO_NOMBRES;
                objDC.RazonSocial = objLR.RAZONSOCIAL == null ? "" : objLR.RAZONSOCIAL;
                objDC.FechaRegistroDigital = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRODIGITAL) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRODIGITAL);

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
