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
    public class JefeDirectoTL
    {
        #region metodos GPPP
        public static JefeDirectoCollectionDC TranslateJefeDirectoXNombreXApellidoXDNIToJefeDirectoCollectionDC(List<uspJefeDirecto_ListarXNombreXApellidoXDNIResult> objLR)
        {
            JefeDirectoCollectionDC collection;

            try
            {
                collection = new JefeDirectoCollectionDC();
                collection.LstJefeDirecto = new Collection<JefeDirectoDC>();

                for (int i = 0; i < objLR.Count; i++)
                {
                    collection.LstJefeDirecto.Add(TranslateJefeDirectoXNombreXApellidoXDNIToJefeDirectoDC(objLR[i]));
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

        public static JefeDirectoDC TranslateJefeDirectoXNombreXApellidoXDNIToJefeDirectoDC(uspJefeDirecto_ListarXNombreXApellidoXDNIResult objLR)
        {
            JefeDirectoDC objDC;

            try
            {
                objDC = new JefeDirectoDC();

                objDC.Nombres = objLR.NOMBRES == null ? "" : objLR.NOMBRES;
                objDC.Apellidos = objLR.APELLIDOS == null ? "" : objLR.APELLIDOS;
                objDC.NOMBRECOMPLETO = objLR.NOMBRECOMPLETO == null ? "" : objLR.NOMBRECOMPLETO;
                objDC.Telefono1 = objLR.TELEFONO1 == null ? "" : objLR.TELEFONO1;
                objDC.NroDocumento = objLR.NRODOCUMENTO == null ? "" : objLR.NRODOCUMENTO;
                objDC.FechaRegistro = UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAREGISTRO);
                objDC.FechaModificacion = UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION) == null ? "" : UtilitarioTL.ConvertDateToString(objLR.FECHAMODIFICACION);
                objDC.Cargo = objLR.CARGO == null ? "" : objLR.CARGO;
                objDC.Anexo = objLR.ANEXO == null ? "" : objLR.ANEXO;
                objDC.JefeDirectoId = objLR.JEFEDIRECTOID;

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
