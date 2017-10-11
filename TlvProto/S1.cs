using System;
using System.Collections.Generic;
using TlvSerialise;

namespace TlvProto
{
    class S2 : ITlvSerialisable
    {
        [Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_ORIG_CODE)]
        public String First { get; set; } 

        [Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_DEST_CODE)]
        public string Second { get; set; }
    }
    class S1 : ITlvSerialisable
    {
        //[Tlv(TlvTypes.UInt, TlvTags.ID_PROD_FFL_NUMERO_VERSION)]
        public int Version { get; set; } = 67;

        //[Tlv(TlvTypes.String, TlvTags.ID_PROD_FFL_IAP)]
        public string Iap { get; set; } = "TVM45";

        [Tlv(TlvTypes.Date, TlvTags.ID_PROD_FFL_END_DATE), TlvEndDate]
        public DateTime EndDate { get; set; } = DateTime.Now;

        [Tlv(TlvTypes.Array, TlvTags.ID_PROD_FFL_PRODUCT)] // 0x1793
        public List<S2> SList { get; set; } = new List<S2> { new S2 { First = "0438", Second = "0065"} };
    }
    class QuickSelect : ITlvSerialisable
    {
        [Tlv(TlvTypes.UInt, TlvTags.ID_QCKSEL_CODE)]public int Code { get; set; }

        [Tlv(TlvTypes.Date, TlvTags.ID_QCKSEL_END_DATE), TlvEndDate]
        public DateTime EndDate { get; set; }
        [Tlv(TlvTypes.Date, TlvTags.ID_QCKSEL_START_DATE)]
        public DateTime StartDate { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_ORIGIN)]
        public string Origin { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_DESTINATION)]
        public string Destination { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_ROUTE)]
        public string Route { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_TICKET)]
        public string Ticket { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_RESTRICTION)]
        public string Restriction { get; set; }
        [Tlv(TlvTypes.UInt, TlvTags.ID_QCKSEL_ADULT_FARE)]
        public int AdultFare { get; set; }
        [Tlv(TlvTypes.UInt, TlvTags.ID_QCKSEL_CROSS_LONDON_IND)]
        public int CrossLondonInd { get; set; }
        [Tlv(TlvTypes.UInt, TlvTags.ID_QCKSEL_FLAG)]
        public int Flag { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_RESTRICTION)]
        public string Status { get; set; }
        [Tlv(TlvTypes.UInt, TlvTags.ID_QCKSEL_ORIENTATION)]
        public int Orientation { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_DATEBAND_NAME)]
        public string DatebandName { get; set; }
        [Tlv(TlvTypes.String, TlvTags.ID_QCKSEL_TIMEBAND_NAME)]
        public string TimebandName { get; set; }
    }

    class Quicks : ITlvSerialisable
    {
        [Tlv(TlvTypes.Array, TlvTags.ID_QCKSEL_PRODUCT)]
        public List<QuickSelect> QSList { get; set; } =
            new List<QuickSelect>
            {
                new QuickSelect
                {
                    Code = 2634,
                    EndDate = DateTime.Now,
                    StartDate = DateTime.MaxValue,
                    Origin = "8553",
                    Destination = "8487",
                    Route = "00000",
                    Ticket = "SDS",
                    Restriction = "  ",
                    AdultFare = 370,
                    CrossLondonInd = 0,
                    Flag = 1,
                    Status = "000",
                    Orientation = 0,
                    DatebandName = "YYYYYYY",
                    TimebandName = "All"
                }
            };
    }
}

