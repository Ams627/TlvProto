﻿namespace TlvSerialise
{
    public enum TlvTags
    {
        ID_PROD_FFL_NUMERO_VERSION = 6033,
        ID_PROD_FFL_IAP = 6034,
        ID_PROD_FFL_PRODUCT = 6035,
        ID_PROD_FFL_ORIG_CODE = 6036,
        ID_PROD_FFL_DEST_CODE = 6037,
        ID_PROD_FFL_ROUTE_CODE = 6038,
        ID_PROD_FFL_STATUS_CODE = 6039,
        ID_PROD_FFL_END_DATE = 6041,
        ID_PROD_FFL_START_DATE = 6042,
        ID_PROD_FFL_TOC = 6043,
        ID_PROD_FFL_CROSS_LONDON_IND = 6044,
        ID_PROD_FFL_NS_DISC_IND = 6045,
        ID_PROD_FFL_PRODUCT_DESC = 6047,
        ID_PROD_FFL_TICKET_CODE = 6048,
        ID_PROD_FFL_FARE = 6049,
        ID_PROD_FFL_RESTRICTION_CODE = 6050,

        ID_QCKSEL_PRODUCT = 6515,
        ID_QCKSEL_CODE = 6516,
        ID_QCKSEL_END_DATE = 6517,
        ID_QCKSEL_START_DATE = 6518,
        ID_QCKSEL_ORIGIN = 6520,
        ID_QCKSEL_DESTINATION = 6521,
        ID_QCKSEL_ROUTE = 6522,
        ID_QCKSEL_TICKET = 6523,
        ID_QCKSEL_RESTRICTION = 6524,
        ID_QCKSEL_ADULT_FARE = 6526,
        ID_QCKSEL_CROSS_LONDON_IND = 6528,
        ID_QCKSEL_FLAG = 6529,
        ID_QCKSEL_STATUS = 6530,
        ID_QCKSEL_ORIENTATION = 6538,
        ID_QCKSEL_DATEBAND_NAME = 6539,
        ID_QCKSEL_TIMEBAND_NAME = 6541,

        ID_CAL_ANNEE1 = 369,
        ID_CAL_CALENDRIER1 = 372,
        ID_CAL_CALENDRIER2 = 373,
        ID_CAL_CALENDRIER3 = 374,
        ID_FMT_IMPR_ART = 91,
        ID_FMT_IMPR_FNAME = 93,
        ID_FMT_IMPR_IMP = 97,
        ID_FMT_IMPR_MASK = 92,
        ID_FMT_IMPR_TYPE = 94,
        ID_FMT_IMPR_UTIL = 96,
        ID_FMT_MS_IAP = 3,
        ID_FORMAT_FICHIER = 3,
        ID_GEORAIL_DESC = 6467,
        ID_GEORAIL_END_DATE = 6470,
        ID_GEORAIL_IAP = 6466,
        ID_GEORAIL_NUMERO_VERSION = 6465,
        ID_GEORAIL_RAILCARD_CODE = 6469,
        ID_GEORAIL_UIC_CODE = 6468,
        ID_JOURNEY_SEG_CODE = 6596,
        ID_JOURNEY_SEG_DESC = 6595,
        ID_JOURNEY_SEG_END = 6601,
        ID_JOURNEY_SEG_END_DATE = 6597,
        ID_JOURNEY_SEG_IAP = 6594,
        ID_JOURNEY_SEG_LINE = 6599,
        ID_JOURNEY_SEG_NUMERO_VERSION = 6593,
        ID_JOURNEY_SEG_START = 6600,
        ID_JOURNEY_SEG_START_DATE = 6598,
        ID_LOCATIONS_ADMIN_AREA_CODE = 6424,
        ID_LOCATIONS_CC_DESC_OUT = 6438,
        ID_LOCATIONS_CC_DESC_RTN = 6439,
        ID_LOCATIONS_COUNTY = 6432,
        ID_LOCATIONS_CRS_CODE = 6427,
        ID_LOCATIONS_DESC = 6419,
        ID_LOCATIONS_DESCRIPTION = 6426,
        ID_LOCATIONS_END_DATE = 6421,
        ID_LOCATIONS_ERS_CODE = 6430,
        ID_LOCATIONS_ERS_COUNTRY = 6429,
        ID_LOCATIONS_FARE_GROUP = 6431,
        ID_LOCATIONS_HIERARCHY = 6437,
        ID_LOCATIONS_IAP = 6418,
        ID_LOCATIONS_KEYBOARD = 6460,
        ID_LOCATIONS_LUL_DIRECTION_IND = 6443,
        ID_LOCATIONS_LUL_UTS_LONDON_STN = 6451,
        ID_LOCATIONS_LUL_UTS_MODE = 6444,
        ID_LOCATIONS_LUL_ZONE_1 = 6445,
        ID_LOCATIONS_LUL_ZONE_2 = 6446,
        ID_LOCATIONS_LUL_ZONE_3 = 6447,
        ID_LOCATIONS_LUL_ZONE_4 = 6448,
        ID_LOCATIONS_LUL_ZONE_5 = 6449,
        ID_LOCATIONS_LUL_ZONE_6 = 6450,
        ID_LOCATIONS_NLC_CODE = 6425,
        ID_LOCATIONS_NUMERO_VERSION = 6417,
        ID_LOCATIONS_PTE_CODE = 6433,
        ID_LOCATIONS_QUOTE_DATE = 6423,
        ID_LOCATIONS_REGION = 6436,
        ID_LOCATIONS_RESV_CODE = 6428,
        ID_LOCATIONS_SPECIAL_FACILITIES = 6442,
        ID_LOCATIONS_START_DATE = 6422,
        ID_LOCATIONS_UIC_CODE = 6420,
        ID_LOCATIONS_UST_WEST = 6459,
        ID_LOCATIONS_UTS_A_CODE = 6453,
        ID_LOCATIONS_UTS_CODE = 6452,
        ID_LOCATIONS_UTS_EAST = 6457,
        ID_LOCATIONS_UTS_NORTH = 6456,
        ID_LOCATIONS_UTS_OFFSET = 6455,
        ID_LOCATIONS_UTS_PTR_BIAS = 6454,
        ID_LOCATIONS_UTS_SOUTH = 6458,
        ID_LOCATIONS_ZONE_IND = 6435,
        ID_LOCATIONS_ZONE_NO = 6434,
        ID_POP_CODE = 6580,
        ID_POP_IAP = 6578,
        ID_POP_NUMERO_VERSION = 6577,
        ID_POP_POPULAR = 6579,
        ID_PRINTP_IAP = 6226,
        ID_PRINTP_NUMERO_VERSION = 6225,
        ID_PRINTP_POINTER = 6227,
        ID_PRINTP_RAILCARD_CODE = 6229,
        ID_PRINTP_REV_CODE = 6230,
        ID_PRINTP_SUPPLEMENT_CODE = 6228,
        ID_PRINTP_TEXT_CODE_1 = 6231,
        ID_PRINTT_FREE_TEXT = 6245,
        ID_PRINTT_IAP = 6242,
        ID_PRINTT_NUMERO_VERSION = 6241,
        ID_PRINTT_POINTER = 6243,
        ID_PRINTT_TEXT_CODE = 6244,
        ID_PROD_FNS_ADULT_ADD_ON_AMOUNT = 6126,
        ID_PROD_FNS_ADULT_NODIS_FLAG = 6125,
        ID_PROD_FNS_ADULT_REBOOK_FLAG = 6127,
        ID_PROD_FNS_CHILD_ADD_ON_AMOUNT = 6129,
        ID_PROD_FNS_CHILD_NODIS_FLAG = 6128,
        ID_PROD_FNS_CHILD_REBOOK_FLAG = 6130,
        ID_PROD_FNS_DEST_CODE = 6117,
        ID_PROD_FNS_END_DATE = 6121,
        ID_PROD_FNS_IAP = 6114,
        ID_PROD_FNS_NUMERO_VERSION = 6113,
        ID_PROD_FNS_ORIG_CODE = 6116,
        ID_PROD_FNS_PRODUCT = 6115,
        ID_PROD_FNS_QUOTE_DATE = 6123,
        ID_PROD_FNS_RAILCARD_CODE = 6120,
        ID_PROD_FNS_ROUTE_CODE = 6118,
        ID_PROD_FNS_START_DATE = 6122,
        ID_PROD_FNS_TICKET_CODE = 6119,
        ID_PROD_FNS_USE_NLC = 6124,
        ID_PROD_NDF_ADULT_FARE = 6092,
        ID_PROD_NDF_CHILD_FARE = 6093,
        ID_PROD_NDF_COMPOSITE_INDICATOR = 6095,
        ID_PROD_NDF_CROSS_LONDON_IND = 6096,
        ID_PROD_NDF_DEST_CODE = 6085,
        ID_PROD_NDF_END_DATE = 6089,
        ID_PROD_NDF_IAP = 6082,
        ID_PROD_NDF_NUMERO_VERSION = 6081,
        ID_PROD_NDF_ORIG_CODE = 6084,
        ID_PROD_NDF_PRODUCT = 6083,
        ID_PROD_NDF_PS_INDICATOR = 6097,
        ID_PROD_NDF_QUOTE_DATE = 6091,
        ID_PROD_NDF_RAILCARD_CODE = 6087,
        ID_PROD_NDF_RESTRICTION_CODE = 6094,
        ID_PROD_NDF_ROUTE_CODE = 6086,
        ID_PROD_NDF_START_DATE = 6090,
        ID_PROD_NDF_TICKET_CODE = 6088,
        ID_QCKSEL_IAP = 6514,
        ID_QCKSEL_NUMERO_VERSION = 6513,
        ID_QCKSEL_TIMEBAND_ARRAY = 6542,
        ID_QCKSEL_TIMEBAND_END = 6537,
        ID_QCKSEL_TIMEBAND_START = 6536,
        ID_QCKSEL_TIMEBAND_TABLE = 6535,
        ID_RAILCARD_AAA_STATUS = 6289,
        ID_RAILCARD_ADULT_STATUS = 6287,
        ID_RAILCARD_CAPRI_TICKET_TYPE = 6286,
        ID_RAILCARD_CHILD_STATUS = 6288,
        ID_RAILCARD_CODE = 6260,
        ID_RAILCARD_DESCRIPTION = 6265,
        ID_RAILCARD_DISCOUNTED_PRICE = 6283,
        ID_RAILCARD_DISPLAY_FLAG = 6271,
        ID_RAILCARD_END_DATE = 6261,
        ID_RAILCARD_HOLDER_TYPE = 6264,
        ID_RAILCARD_IAP = 6258,
        ID_RAILCARD_LAST_VALID_DATE = 6285,
        ID_RAILCARD_MASTER_CODE = 6270,
        ID_RAILCARD_MAX_ACC_ADULTS = 6276,
        ID_RAILCARD_MAX_ADULTS = 6278,
        ID_RAILCARD_MAX_CHILDREN = 6280,
        ID_RAILCARD_MAX_HOLDERS = 6274,
        ID_RAILCARD_MAX_PASSENGERS = 6272,
        ID_RAILCARD_MIN_ACC_ADULTS = 6277,
        ID_RAILCARD_MIN_ADULTS = 6279,
        ID_RAILCARD_MIN_CHILDREN = 6281,
        ID_RAILCARD_MIN_DESC = 6307,
        ID_RAILCARD_MIN_END_DATE = 6310,
        ID_RAILCARD_MIN_HOLDERS = 6275,
        ID_RAILCARD_MIN_IAP = 6306,
        ID_RAILCARD_MIN_MINIMUM_FARE = 6312,
        ID_RAILCARD_MIN_NUMERO_VERSION = 6305,
        ID_RAILCARD_MIN_PASSENGERS = 6273,
        ID_RAILCARD_MIN_RAILCARD_CODE = 6308,
        ID_RAILCARD_MIN_START_DATE = 6311,
        ID_RAILCARD_MIN_TICKET_CODE = 6309,
        ID_RAILCARD_NUMERO_VERSION = 6257,
        ID_RAILCARD_QUOTE_DATE = 6263,
        ID_RAILCARD_RAILCARD = 6259,
        ID_RAILCARD_RESTRICTED_BY_AREA = 6267,
        ID_RAILCARD_RESTRICTED_BY_DATE = 6269,
        ID_RAILCARD_RESTRICTED_BY_ISSUE = 6266,
        ID_RAILCARD_RESTRICTED_BY_TRAIN = 6268,
        ID_RAILCARD_START_DATE = 6262,
        ID_RAILCARD_VAL_PERIOD_DAYS = 6290,
        ID_RAILCARD_VAL_PERIOD_MONTHS = 6284,
        ID_RAILROVER_CAPRI_TICKET_CODE = 6858,
        ID_RAILROVER_CODE = 6852,
        ID_RAILROVER_DAYS_TRAVEL = 6860,
        ID_RAILROVER_DAYS_VALID = 6862,
        ID_RAILROVER_DESC = 6851,
        ID_RAILROVER_DESCRIPTION = 6856,
        ID_RAILROVER_END_DATE = 6853,
        ID_RAILROVER_IAP = 6850,
        ID_RAILROVER_MONTHS_VALID = 6861,
        ID_RAILROVER_NUMERO_VERSION = 6849,
        ID_RAILROVER_QUOTE_DATE = 6855,
        ID_RAILROVER_ROVER_ACCOUNTING_CODE = 6859,
        ID_RAILROVER_START_DATE = 6854,
        ID_RAILROVER_TICKET_DESC = 6857,
        ID_RESTRICTION_EC_CF_MKR = 6804,
        ID_RESTRICTION_EC_CODE = 6805,
        ID_RESTRICTION_EC_DESC = 6803,
        ID_RESTRICTION_EC_DESCRIPTION = 6806,
        ID_RESTRICTION_EC_IAP = 6802,
        ID_RESTRICTION_EC_NUMERO_VERSION = 6801,
        ID_RESTRICTION_HA_DESC = 6787,
        ID_RESTRICTION_HA_IAP = 6786,
        ID_RESTRICTION_HA_NUMERO_VERSION = 6785,
        ID_RESTRICTION_HC_DESC = 6675,
        ID_RESTRICTION_HC_IAP = 6674,
        ID_RESTRICTION_HC_NUMERO_VERSION = 6673,
        ID_RESTRICTION_HD_CF_MKR = 6644,
        ID_RESTRICTION_HD_CODE = 6645,
        ID_RESTRICTION_HD_DATE_FROM = 6646,
        ID_RESTRICTION_HD_DATE_TO = 6647,
        ID_RESTRICTION_HD_DAYS = 6648,
        ID_RESTRICTION_HD_DESC = 6643,
        ID_RESTRICTION_HD_IAP = 6642,
        ID_RESTRICTION_HD_NUMERO_VERSION = 6641,
        ID_RESTRICTION_HL_DESC = 6659,
        ID_RESTRICTION_HL_IAP = 6658,
        ID_RESTRICTION_HL_NUMERO_VERSION = 6657,
        ID_RESTRICTION_RD_CF_MKR = 6612,
        ID_RESTRICTION_RD_DESC = 6611,
        ID_RESTRICTION_RD_END_DATE = 6614,
        ID_RESTRICTION_RD_IAP = 6610,
        ID_RESTRICTION_RD_NUMERO_VERSION = 6609,
        ID_RESTRICTION_RD_START_DATE = 6613,
        ID_RESTRICTION_RH_CF_MKR = 6628,
        ID_RESTRICTION_RH_CHANGE_IND = 6635,
        ID_RESTRICTION_RH_CODE = 6629,
        ID_RESTRICTION_RH_DESC = 6627,
        ID_RESTRICTION_RH_DESCRIPTION = 6630,
        ID_RESTRICTION_RH_DESC_OUT = 6631,
        ID_RESTRICTION_RH_DESC_RTN = 6632,
        ID_RESTRICTION_RH_IAP = 6626,
        ID_RESTRICTION_RH_NUMERO_VERSION = 6625,
        ID_RESTRICTION_RH_TYPE_OUT = 6633,
        ID_RESTRICTION_RH_TYPE_RTN = 6634,
        ID_RESTRICTION_RR_CF_MKR = 6564,
        ID_RESTRICTION_RR_DESC = 6563,
        ID_RESTRICTION_RR_IAP = 6562,
        ID_RESTRICTION_RR_LOCATION = 6569,
        ID_RESTRICTION_RR_NUMERO_VERSION = 6561,
        ID_RESTRICTION_RR_RAILCARD_CODE = 6565,
        ID_RESTRICTION_RR_RESTRICTION_CODE = 6570,
        ID_RESTRICTION_RR_ROUTE_CODE = 6568,
        ID_RESTRICTION_RR_SEQUENCE = 6566,
        ID_RESTRICTION_RR_TICKET_CODE = 6567,
        ID_RESTRICTION_RR_TOTAL_BAN = 6571,
        ID_RESTRICTION_SD_DESC = 6755,
        ID_RESTRICTION_SD_IAP = 6754,
        ID_RESTRICTION_SD_NUMERO_VERSION = 6753,
        ID_RESTRICTION_SQ_ARR_DEP = 6778,
        ID_RESTRICTION_SQ_CF_MKR = 6772,
        ID_RESTRICTION_SQ_CODE = 6773,
        ID_RESTRICTION_SQ_DESC = 6771,
        ID_RESTRICTION_SQ_IAP = 6770,
        ID_RESTRICTION_SQ_LOCATION = 6776,
        ID_RESTRICTION_SQ_NUMERO_VERSION = 6769,
        ID_RESTRICTION_SQ_OUT_RET = 6775,
        ID_RESTRICTION_SQ_QUOTA_IND = 6777,
        ID_RESTRICTION_SQ_TRAIN_NO = 6774,
        ID_RESTRICTION_SR_CF_MKR = 6740,
        ID_RESTRICTION_SR_CODE = 6741,
        ID_RESTRICTION_SR_DESC = 6739,
        ID_RESTRICTION_SR_IAP = 6738,
        ID_RESTRICTION_SR_NUMERO_VERSION = 6737,
        ID_RESTRICTION_SR_OUT_RET = 6743,
        ID_RESTRICTION_SR_QUOTA_IND = 6744,
        ID_RESTRICTION_SR_SLEEPER_IND = 6745,
        ID_RESTRICTION_SR_TRAIN_NO = 6742,
        ID_RESTRICTION_TD_CF_MKR = 6708,
        ID_RESTRICTION_TD_CODE = 6709,
        ID_RESTRICTION_TD_DATE_FROM = 6712,
        ID_RESTRICTION_TD_DATE_TO = 6713,
        ID_RESTRICTION_TD_DAYS = 6714,
        ID_RESTRICTION_TD_DESC = 6707,
        ID_RESTRICTION_TD_IAP = 6706,
        ID_RESTRICTION_TD_NUMERO_VERSION = 6705,
        ID_RESTRICTION_TD_OUT_RET = 6711,
        ID_RESTRICTION_TD_SEQUENCE_NO = 6710,
        ID_RESTRICTION_TR_ARR_DEP_VIA = 6698,
        ID_RESTRICTION_TR_CF_MKR = 6692,
        ID_RESTRICTION_TR_CODE = 6693,
        ID_RESTRICTION_TR_DESC = 6691,
        ID_RESTRICTION_TR_IAP = 6690,
        ID_RESTRICTION_TR_LOCATION = 6699,
        ID_RESTRICTION_TR_MIN_FARE_FLAG = 6702,
        ID_RESTRICTION_TR_NUMERO_VERSION = 6689,
        ID_RESTRICTION_TR_OUT_RET = 6695,
        ID_RESTRICTION_TR_RSTR_TYPE = 6700,
        ID_RESTRICTION_TR_SEQUENCE_NO = 6694,
        ID_RESTRICTION_TR_TIME_FROM = 6696,
        ID_RESTRICTION_TR_TIME_TO = 6697,
        ID_RESTRICTION_TR_TRAIN_TYPE = 6701,
        ID_RESTRICTION_TT_CF_MKR = 6724,
        ID_RESTRICTION_TT_CODE = 6725,
        ID_RESTRICTION_TT_DESC = 6723,
        ID_RESTRICTION_TT_IAP = 6722,
        ID_RESTRICTION_TT_NUMERO_VERSION = 6721,
        ID_RESTRICTION_TT_OUT_RET = 6727,
        ID_RESTRICTION_TT_SEQUENCE_NO = 6726,
        ID_RESTRICTION_TT_TOC_CODE = 6728,
        ID_ROUNDING_RULES_DESC = 6371,
        ID_ROUNDING_RULES_END_DATE = 6373,
        ID_ROUNDING_RULES_IAP = 6370,
        ID_ROUNDING_RULES_INDEX = 6374,
        ID_ROUNDING_RULES_MAX_AMOUNT = 6376,
        ID_ROUNDING_RULES_NO = 6372,
        ID_ROUNDING_RULES_NUMERO_VERSION = 6369,
        ID_ROUNDING_RULES_ROUND_AMOUNT = 6377,
        ID_ROUNDING_RULES_START_DATE = 6375,
        ID_ROUTE_AAA_DESC = 6494,
        ID_ROUTE_ATB_DESC_1 = 6489,
        ID_ROUTE_ATB_DESC_2 = 6490,
        ID_ROUTE_ATB_DESC_3 = 6491,
        ID_ROUTE_ATB_DESC_4 = 6492,
        ID_ROUTE_CC_DESC = 6493,
        ID_ROUTE_CODE = 6484,
        ID_ROUTE_DESCRIPTION = 6488,
        ID_ROUTE_END_DATE = 6485,
        ID_ROUTE_IAP = 6482,
        ID_ROUTE_NUMERO_VERSION = 6481,
        ID_ROUTE_QUOTE_DATE = 6487,
        ID_ROUTE_ROUTES = 6483,
        ID_ROUTE_START_DATE = 6486,
        ID_ROUTE_UTS_EAST = 6503,
        ID_ROUTE_UTS_MODE = 6495,
        ID_ROUTE_UTS_NORTH = 6502,
        ID_ROUTE_UTS_SOUTH = 6504,
        ID_ROUTE_UTS_WEST = 6505,
        ID_ROUTE_UTS_ZONE_1 = 6496,
        ID_ROUTE_UTS_ZONE_2 = 6497,
        ID_ROUTE_UTS_ZONE_3 = 6498,
        ID_ROUTE_UTS_ZONE_4 = 6499,
        ID_ROUTE_UTS_ZONE_5 = 6500,
        ID_ROUTE_UTS_ZONE_6 = 6501,
        ID_STACLUS_CLUSTER_ID = 6068,
        ID_STACLUS_CLUSTER_NLC = 6069,
        ID_STACLUS_DESC = 6067,
        ID_STACLUS_END_DATE = 6070,
        ID_STACLUS_IAP = 6066,
        ID_STACLUS_NUMERO_VERSION = 6065,
        ID_STACLUS_START_DATE = 6071,
        ID_STATUS_CC_DESC = 6328,
        ID_STATUS_CODE = 6324,
        ID_STATUS_DISCOUNT_CATEGORY = 6358,
        ID_STATUS_DISCOUNT_CODE = 6356,
        ID_STATUS_DISCOUNT_DESC = 6355,
        ID_STATUS_DISCOUNT_END_DATE = 6357,
        ID_STATUS_DISCOUNT_IAP = 6354,
        ID_STATUS_DISCOUNT_INDICATOR = 6359,
        ID_STATUS_DISCOUNT_NUMERO_VERSION = 6353,
        ID_STATUS_DISCOUNT_PERCENTAGE = 6360,
        ID_STATUS_END_DATE = 6325,
        ID_STATUS_FIRST_HIGHER_MIN = 6335,
        ID_STATUS_FIRST_LOWER_MIN = 6334,
        ID_STATUS_FIRST_RETURN_MAX_FLAT = 6331,
        ID_STATUS_FIRST_SINGLE_MAX_FLAT = 6330,
        ID_STATUS_FR_MKR = 6339,
        ID_STATUS_FS_MKR = 6338,
        ID_STATUS_IAP = 6322,
        ID_STATUS_NUMERO_VERSION = 6321,
        ID_STATUS_SR_MKR = 6341,
        ID_STATUS_SS_MKR = 6340,
        ID_STATUS_START_DATE = 6326,
        ID_STATUS_STATUS = 6323,
        ID_STATUS_STD_HIGHER_MIN = 6337,
        ID_STATUS_STD_LOWER_MIN = 6336,
        ID_STATUS_STD_RETURN_MAX_FLAT = 6333,
        ID_STATUS_STD_SINGLE_MAX_FLAT = 6332,
        ID_STATUS_UTS_CODE = 6329,
        ID_SUPPLEMENTS_CAPRI_CODE = 6833,
        ID_SUPPLEMENTS_CLASS_TYPE = 6832,
        ID_SUPPLEMENTS_CPF_TICKET_TYPE = 6828,
        ID_SUPPLEMENTS_DESC = 6819,
        ID_SUPPLEMENTS_DESCRIPTION = 6824,
        ID_SUPPLEMENTS_END_DATE = 6821,
        ID_SUPPLEMENTS_IAP = 6818,
        ID_SUPPLEMENTS_MAX_GROUP_SIZE = 6830,
        ID_SUPPLEMENTS_MIN_GROUP_SIZE = 6829,
        ID_SUPPLEMENTS_NUMERO_VERSION = 6817,
        ID_SUPPLEMENTS_PER_LEG_OR_DIR = 6831,
        ID_SUPPLEMENTS_PRICE = 6827,
        ID_SUPPLEMENTS_QUOTE_DATE = 6823,
        ID_SUPPLEMENTS_RESVN_TYPE = 6835,
        ID_SUPPLEMENTS_SEP_TKT_IND = 6834,
        ID_SUPPLEMENTS_SHORT_DESC = 6825,
        ID_SUPPLEMENTS_START_DATE = 6822,
        ID_SUPPLEMENTS_SUNDRY_CODE = 6836,
        ID_SUPPLEMENTS_SUPPLEMENT_CODE = 6820,
        ID_SUPPLEMENTS_SUPPL_TYPE = 6826,
        ID_SYN_NUMERO_VERSION = 6545,
        ID_SYN_SYNONYM = 6546,
        ID_TCKTYPE_CAPRI_CODE = 6170,
        ID_TCKTYPE_CLASS = 6153,
        ID_TCKTYPE_CODE = 6148,
        ID_TCKTYPE_DAY_MASK = 6180,
        ID_TCKTYPE_DESCRIPTION = 6152,
        ID_TCKTYPE_DESC_CUSTOM = 6183,
        ID_TCKTYPE_DISCOUNT_CATEGORY = 6176,
        ID_TCKTYPE_DURATION = 6182,
        ID_TCKTYPE_END_DATE = 6149,
        ID_TCKTYPE_END_TIME = 6179,
        ID_TCKTYPE_FARE_MULTIPLIER = 6175,
        ID_TCKTYPE_FORMAT = 6177,
        ID_TCKTYPE_FREE_PASS_LUL = 6174,
        ID_TCKTYPE_IAP = 6146,
        ID_TCKTYPE_LAST_VALID_DAY = 6156,
        ID_TCKTYPE_LUL_93 = 6171,
        ID_TCKTYPE_LUL_XLONDON_ISSUE = 6168,
        ID_TCKTYPE_MAX_ADULT = 6159,
        ID_TCKTYPE_MAX_CHILDREN = 6161,
        ID_TCKTYPE_MAX_PASSENGERS = 6157,
        ID_TCKTYPE_MIN_ADULT = 6160,
        ID_TCKTYPE_MIN_CHILDREN = 6162,
        ID_TCKTYPE_MIN_PASSENGERS = 6158,
        ID_TCKTYPE_NUMERO_VERSION = 6145,
        ID_TCKTYPE_PER = 6181,
        ID_TCKTYPE_QUOTE_DATE = 6151,
        ID_TCKTYPE_RESERVATION_REQUIRED = 6169,
        ID_TCKTYPE_RESTRICTED_BY_AREA = 6165,
        ID_TCKTYPE_RESTRICTED_BY_DATE = 6163,
        ID_TCKTYPE_RESTRICTED_BY_TRAIN = 6164,
        ID_TCKTYPE_START_DATE = 6150,
        ID_TCKTYPE_START_TIME = 6178,
        ID_TCKTYPE_TICKET = 6147,
        ID_TCKTYPE_TIME_RESTRICTION = 6173,
        ID_TCKTYPE_TYPE = 6154,
        ID_TCKTYPE_UTS_CODE = 6172,
        ID_TCKTYPE_VALIDITY_CODE = 6166,
        ID_TCKVALIDITY_BREAK_OUT = 6207,
        ID_TCKVALIDITY_BREAK_RTN = 6208,
        ID_TCKVALIDITY_CODE = 6196,
        ID_TCKVALIDITY_DESCRIPTION = 6199,
        ID_TCKVALIDITY_END_DATE = 6197,
        ID_TCKVALIDITY_IAP = 6194,
        ID_TCKVALIDITY_NUMERO_VERSION = 6193,
        ID_TCKVALIDITY_OUT_DAYS = 6200,
        ID_TCKVALIDITY_OUT_DESCRIPTION = 6209,
        ID_TCKVALIDITY_OUT_MONTHS = 6201,
        ID_TCKVALIDITY_RET_AFTER_DAY = 6206,
        ID_TCKVALIDITY_RET_AFTER_DAYS = 6204,
        ID_TCKVALIDITY_RET_AFTER_MONTHS = 6205,
        ID_TCKVALIDITY_RET_DAYS = 6202,
        ID_TCKVALIDITY_RET_MONTHS = 6203,
        ID_TCKVALIDITY_RTN_DESCRIPTION = 6210,
        ID_TCKVALIDITY_START_DATE = 6198,
        ID_TCKVALIDITY_VALIDITY = 6195
    }
}
