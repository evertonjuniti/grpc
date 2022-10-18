using NetCoreIso8583x64Lib;

namespace NetCoreHelperLib
{
    [ISO_8583(standard: STANDARD.ISO_8583_1993)]
    public class GenericChildModel
    {
        private double doubleValue;

        public GenericChildModel()
        {
            Type = "2";
        }

        [ISO_8583_1993(field: ISO_8583_1993.Additional_Response_Data)]
        public string Type { get; private set; }

        [ISO_8583_1993(field: ISO_8583_1993.Transport_Data)]
        public long ItemId { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Reserved_for_Private_use_3)]
        public string Description { get; set; }
                
        public double Value
        {
            get
            {
                return doubleValue;
            }
            set
            {
                doubleValue = value;
                Value_ISO8583 = doubleValue.ToString().Replace(",", "");
            }
        }

        [ISO_8583_1993(field: ISO_8583_1993.Amounts_Original)]
        public string Value_ISO8583
        {
            get
            {
                return doubleValue.ToString().Replace(",", "");
            }
            set
            {
                doubleValue = double.Parse(value.Substring(0, value.Length - 2) + "," + value.Substring(value.Length - 2, 2));
            }
        }
    }
}
