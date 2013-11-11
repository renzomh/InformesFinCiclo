using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

using System.Collections;
using System.Collections.ObjectModel;

namespace UPC.SSIA2013.WS.DataContract
{
    [CollectionDataContract]
    public class CarreraCollectionDC : List<CarreraDC>
    {
    }

    //#region metodos GPPP
    //[DataContract]
    //public class CarreraCollectionDC
    //{
    //    private Collection<CarreraDC> _lstCarrera;

    //    [DataMember]
    //    public Collection<CarreraDC> lstCarrera
    //    {
    //        get { return _lstCarrera; }
    //        set { _lstCarrera = value; }
    //    }
    //}
    //#endregion
}
