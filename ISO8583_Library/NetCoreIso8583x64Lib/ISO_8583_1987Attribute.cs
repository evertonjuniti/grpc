namespace NetCoreIso8583x64Lib
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ISO_8583_1987Attribute : Attribute
    {
        private ISO_8583_1987 field;

        public virtual ISO_8583_1987 Field
        {
            get { return this.field; }
        }

        public ISO_8583_1987Attribute(ISO_8583_1987 field)
        {
            this.field = field;
        }
    }
}
