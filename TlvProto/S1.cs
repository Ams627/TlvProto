using System;
using System.Collections.Generic;

namespace TlvProto
{
    class S2 : TlvSerialisable
    {
        [Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_ORIG_CODE)]
        public String First { get; set; } 

        [Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_DEST_CODE)]
        public string Second { get; set; }
    }
    class S1 : TlvSerialisable
    {
        [Tlv(TlvTypes.UInt, TlvTags.ID_PROD_FFL_NUMERO_VERSION)]
        public int Version { get; set; } = 67;

        [Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_IAP)]
        public string Iap { get; set; } = "TVM45";

//        [Tlv(TlvTypes.Date, TlvTags.ID_PROD_FFL_END_DATE)]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Tlv(TlvTypes.Array, TlvTags.ID_PROD_FFL_PRODUCT)] // 0x1793
        public List<S2> SList { get; set; } = new List<S2> { new S2 { First = "0438", Second = "0065"} };
    }
}
