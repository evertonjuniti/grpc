namespace NetCoreIso8583x64Lib
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ISO_8583_1993Attribute : Attribute
    {
        private ISO_8583_1993 field;

        public virtual ISO_8583_1993 Field
        {
            get { return this.field; }
        }

        public ISO_8583_1993Attribute(ISO_8583_1993 field)
        {
            this.field = field;
        }
    }
}
