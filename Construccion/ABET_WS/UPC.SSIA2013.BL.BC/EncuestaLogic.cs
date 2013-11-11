using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.SSIA2013.DataAccess;
using UPC.SSIA2013.BusinessEntity;
using UPC.SSIA2013.DataModel;
using UPC.SSIA2013.WS.DataContract;

namespace UPC.SSIA2013.BusinessLogic
{
    public class EncuestaLogic
    {
        #region metodos GPPP
        public List<uspEncuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistroResult> encuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistro(Int32 Carrera, Int32 Periodo, Int32 PPP, Int32? Estado, String TipoRegistro)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                return objDALC.encuesta_ListarXCarreraXPeriodoXPPPXEstadoXTipoRegistro(Carrera,Periodo,PPP,Estado,TipoRegistro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EncuestaDC encuesta_Obtener(Int32 EncuestaId)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                uspEncuesta_ObetenerXEncuestaIdResult obj = objDALC.encuesta_ObtenerxEncuestaId(EncuestaId);
                EncuestaDC objDC = new EncuestaDC();
                objDC.ALUMNO_APELLIDOS = obj.ALUMNO_APELLIDOS;
                objDC.ALUMNO_NOMBRES = obj.ALUMNO_NOMBRES;
                objDC.AlumnoId = obj.ALUMNOID;
                objDC.CarreraId = obj.CARRERAID;
                objDC.Descripcion = obj.DESCRIPCION;
                objDC.EmpresaId = obj.EMPRESAID;
                objDC.ENCUESTA_ESTADO = Convert.ToInt32(obj.ENCUESTA_ESTADO);
                objDC.EncuestaId = obj.ENCUESTAID;
                objDC.JEFEDIRECTO_APELLIDOS = obj.JEFEDIRECTO_APELLIDOS;
                objDC.JEFEDIRECTO_NOMBRES = obj.JEFEDIRECTO_NOMBRES;
                objDC.JefeDirectoId = obj.JEFEDIRECTOID;
                objDC.MALLAENCUESTA_ESTADO = obj.MALLAENCUESTA_ESTADO;
                objDC.MALLAENCUESTA_NOMBRE = obj.MALLAENCUESTA_NOMBRE;
                objDC.MallaEncuestaId = obj.MALLAENCUESTAID;
                objDC.PeriodoId = obj.PERIODOID;
                objDC.PersonaId = obj.PERSONAID;
                objDC.PracticaPreProfesionalId = obj.PRACTICAPREPROFESIONALID;
                objDC.RazonSocial = obj.RAZONSOCIAL;
                objDC.TipoRegistro = obj.TIPOREGISTRO;
                objDC.TotalHoras = obj.TOTALHORAS;
                objDC.Cargo = obj.Cargo;
                objDC.Telefono1 = obj.TELEFONO1;
                objDC.Anexo = obj.Anexo;
                objDC.Comentario = obj.Comentario;
                objDC.Direccion = obj.Direccion;
                objDC.FECHAINICIO = obj.FechaInicio.ToString();
                objDC.FECHAFIN = obj.FechaFin.ToString();
                objDC.FechaRegistroJefe = obj.FechaRegistroJefe.ToString();
                objDC.JefeDirectoId = obj.JEFEDIRECTOID;
                objDC.RUC = obj.Ruc;
                objDC.NroDocumento = obj.NroDocumento;
                objDC.Competencias = new List<CompetenciaAbetxEncuestaDC>();
                List<uspEncuesta_ListarCompetenciasResult> lst = objDALC.encuesta_ListarCompetencias(EncuestaId);
                for (int i = 0; i < lst.Count; i++)
                {
                    CompetenciaAbetxEncuestaDC objCom = new CompetenciaAbetxEncuestaDC();
                    objCom.Codigo = lst.ElementAt(i).Codigo;
                    objCom.CompetenciaAbetId = lst.ElementAt(i).CompetenciaAbetId;
                    objCom.Descripcion = lst.ElementAt(i).Descripcion;
                    objCom.Nombre = lst.ElementAt(i).Nombre;
                    objCom.Puntuacion = Convert.ToInt32(lst.ElementAt(i).Puntuacion);
                    objCom.ResutadoProgramaId = lst.ElementAt(i).ResultadoProgramaId;
                    objDC.Competencias.Add(objCom);
                }
                return objDC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 encuesta_Registrar(EncuestaDC objEncuesta)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                Int32 EncuestaID = objDALC.encuesta_Registrar(objEncuesta);
                for (int i = 0; i < objEncuesta.Competencias.Count; i++)
                {
                    objEncuesta.Competencias.ElementAt(i).EncuestaId = EncuestaID;
                    objEncuesta.Competencias.ElementAt(i).MallaEncuestaId = objEncuesta.MallaEncuestaId;
                    objDALC.Encuesta_RegistrarCompetencias(objEncuesta.Competencias.ElementAt(i));
                }
                return EncuestaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 encuesta_Actualizar(EncuestaDC objEncuesta)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                objDALC.encuesta_Actualizar(objEncuesta);
                for (int i = 0; i < objEncuesta.Competencias.Count; i++)
                {
                    objEncuesta.Competencias.ElementAt(i).EncuestaId = objEncuesta.EncuestaId;
                    objEncuesta.Competencias.ElementAt(i).MallaEncuestaId = objEncuesta.MallaEncuestaId;
                    objDALC.encuesta_ActualizarCompetencias(objEncuesta.Competencias.ElementAt(i));
                }
                return objEncuesta.EncuestaId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 encuesta_Eliminar(Int32 EncuestaId)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                return objDALC.encuesta_Eliminar(EncuestaId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<uspEncuesta_ListarXFechasResult> encuesta_ListarXFechas(DateTime FechaFin, DateTime FechaInicio)
        {
            EncuestaDataAccess objDALC;

            try
            {
                objDALC = new EncuestaDataAccess();
                return objDALC.encuesta_ListarXFechas(FechaFin, FechaInicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
