using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UPC.SSIA2013.WS.DataContract
{
    [CollectionDataContract]
    public class CursoCollectionDC: List<CursoDC>
    {
    }
}
