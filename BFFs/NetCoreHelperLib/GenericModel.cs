using NetCoreIso8583x64Lib;

namespace NetCoreHelperLib
{
    [ISO_8583(standard: STANDARD.ISO_8583_1993)]
    public class GenericModel
    {
        private readonly string dateFormat = "yyMMdd";
        private bool active;
        private DateTime date;

        public GenericModel()
        {
            Type = "1";
        }

        [ISO_8583_1993(field: ISO_8583_1993.Additional_Response_Data)]
        public string Type { get; private set; }

        [ISO_8583_1993(field: ISO_8583_1993.Data_Record)]
        public long Id { get; set; }

        [ISO_8583_1993(field: ISO_8583_1993.Reserved_for_Private_use_1)]
        public string Name { get; set; }
                
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;

                if (active)
                    Active_ISO8583 = "1";
                else
                    Active_ISO8583 = "0";
            }
        }

        [ISO_8583_1993(field: ISO_8583_1993.Reserved_for_Private_use_2)]
        public string Active_ISO8583
        {
            get
            {
                return active.Equals(true) ? "1" : "0";
            }
            set
            {
                active = value.Equals("1") ? true : false;
            }
        }
                
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                Date_ISO8583 = date.ToString(dateFormat);
            }
        }

        [ISO_8583_1993(field: ISO_8583_1993.Date_Settlement)]
        public string Date_ISO8583
        {
            get
            {
                return date.ToString(dateFormat);
            }
            set
            {
                date = DateTime.ParseExact(value, dateFormat, null);
            }
        }

        public List<GenericChildModel> Items { get; set; }
    }
}
