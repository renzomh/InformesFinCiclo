﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;

using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UPC.IFCDC.BC
{
    public class AccionMejoraBC
    {
        public AccionMejoraReporteCollectionBE listarReporteAccionMejora(InformeFinCicloBE informe)
        {
            AccionMejoraReporteCollectionBE collection = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarAccionMejoraReporte";
            ServiceHelper objServiceHelper = null;

            try
            {
                objServiceHelper = new ServiceHelper();
                json = objServiceHelper.serializeObjectToJson(informe);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);

                collection = JsonConvert.DeserializeObject<AccionMejoraReporteCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return collection;
        }

        public AccionMejoraCollectionBE registrarAccionesMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSRegistrarAccionMejora";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE editarAccionesMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEditarAccionMejora";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE listarAccionesMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarAccionesMejoraxInformeFinCiclo";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE listarAccionesPrevias(InformeFinCicloBE objInformeFinCicloBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarAccionesMejoraPrevia";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objInformeFinCicloBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }

        public AccionMejoraCollectionBE eliminarAccionMejora(AccionMejoraBE objAccionMejoraBE)
        {
            AccionMejoraCollectionBE objAccionMejoraCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSEliminarAccionMejora";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson(objAccionMejoraBE);
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objAccionMejoraCollectionBE = JsonConvert.DeserializeObject<AccionMejoraCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objAccionMejoraCollectionBE;
        }
    }
}
