using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UPC.IFCDC.BE;
using UPC.IFCDC.Utilitarios;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UPC.IFCDC.BC
{
    public class CursoBC
    {
        public CursoCollectionBE listarCursos()
        {
            CursoCollectionBE objCursoCollectionBE = null;

            HttpWebRequest hwr = null;
            String json = "";
            String sServicio = "WSListarCursos";
            ServiceHelper objServiceHelper = new ServiceHelper();

            try
            {
                json = objServiceHelper.serializeObjectToJson("");
                hwr = objServiceHelper.createHttpWebRequest(sServicio);
                objCursoCollectionBE = JsonConvert.DeserializeObject<CursoCollectionBE>(objServiceHelper.getObject(hwr, json).ReadToEnd());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objCursoCollectionBE;
        }
    }
}
