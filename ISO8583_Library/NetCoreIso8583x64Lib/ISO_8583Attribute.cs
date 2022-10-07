namespace NetCoreIso8583x64Lib
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ISO_8583Attribute : Attribute
    {
        private STANDARD standard = STANDARD.ISO_8583_1993;

        public virtual STANDARD Standard
        {
            get { return this.standard; }
        }

        public ISO_8583Attribute(STANDARD standard)
        {
            this.standard = standard;
        }
    }
}
